using System;
using System.ComponentModel;
using System.Data;
using C968;
using System.Windows.Forms;

namespace C968
{
    public partial class addProductScreen : Form
    {
        private Inventory inventory;
        private Product product;
        public Inventory Inventory { get; set; }
        private int autoIncrementValue = 1;


        public addProductScreen(Inventory inventory, Product product)
        {
            InitializeComponent();
            Product Product = new Product();

            addProductPartsDataGridView.AutoGenerateColumns = false;

            addProductPartsDataGridView.Columns[0].DataPropertyName = "PartID";
            addProductPartsDataGridView.Columns[1].DataPropertyName = "Name";
            addProductPartsDataGridView.Columns[2].DataPropertyName = "InStock";
            addProductPartsDataGridView.Columns[3].DataPropertyName = "Price";
            addProductPartsDataGridView.Columns[4].DataPropertyName = "Min";
            addProductPartsDataGridView.Columns[5].DataPropertyName = "Max";

            addProductPartsDataGridView.DataSource = inventory.AllParts;

            addProductAssociatedPartsDataGridView.AutoGenerateColumns = false;

            addProductAssociatedPartsDataGridView.Columns[0].DataPropertyName = "PartID";
            addProductAssociatedPartsDataGridView.Columns[1].DataPropertyName = "Name";
            addProductAssociatedPartsDataGridView.Columns[2].DataPropertyName = "InStock";
            addProductAssociatedPartsDataGridView.Columns[3].DataPropertyName = "Price";
            addProductAssociatedPartsDataGridView.Columns[4].DataPropertyName = "Min";
            addProductAssociatedPartsDataGridView.Columns[5].DataPropertyName = "Max";

            addProductAssociatedPartsDataGridView.DataSource = candidateParts;
        }
        BindingList<Part> candidateParts = new BindingList<Part>();

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            addProductIDBox.Text = autoIncrementValue.ToString();
            autoIncrementValue--;

            Properties.Settings.Default.AutoIncrementValue2 = autoIncrementValue;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void addProducts_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoIncrementValue2 > 0)
            {
                autoIncrementValue = Properties.Settings.Default.AutoIncrementValue2;
            }
            else
            {
                autoIncrementValue = 1;
            }
            addProductIDBox.Text = autoIncrementValue.ToString();
            autoIncrementValue++;

            Properties.Settings.Default.AutoIncrementValue2 = autoIncrementValue;
            Properties.Settings.Default.Save();
        }
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            BindingList<Part> associatedParts = new BindingList<Part>();

            foreach (Part part in candidateParts)
            {
                associatedParts.Add(part);
            }
            int productID;
            decimal productPrice;
            int productQuantity;
            int productMin;
            int productMax;

            if (int.TryParse(addProductIDBox.Text, out productID))
            {
                product.ProductID = productID;
                if (decimal.TryParse(addProductPriceBox.Text, out productPrice) &&
                addProductPriceBox.Text.Length > 0)
                {
                    product.Price = productPrice;
                    if (int.TryParse(addProductMinBox.Text, out productMin) &&
                    addProductMinBox.Text.Length > 0)
                    {
                        if (int.TryParse(addProductMaxBox.Text, out productMax) &&
                        addProductMaxBox.Text.Length > 0)
                        {
                            if (productMax > productMin)
                            {
                                product.Max = productMax;
                                product.Min = productMin;
                                if (int.TryParse(addProductInventoryBox.Text, out productQuantity) &&
                        addProductInventoryBox.Text.Length > 0)
                                {
                                    if ((productQuantity > productMin) && (productQuantity < productMax))
                                    {
                                        product.InStock = productQuantity;
                                        if (addProductNameBox.Text.Length > 0)
                                        {
                                            product.Name = addProductNameBox.Text;
                                            product.AssociatedParts = associatedParts;
                                            Inventory.addProduct(product);
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a valid product name");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Current stock must be greater than minimum and less than maximum.");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid integer to indicate stock.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product max must be greater than product min.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid integer to indicate maximum stock.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer to indicate minimum stock.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid price.");
                }
            }
            else
            {
                MessageBox.Show("Please enter all valid information.");
            }
        }
        private void addProductAddPartButton_Click(object sender, EventArgs e)
        {
            if (addProductPartsDataGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = addProductPartsDataGridView.SelectedRows[0];
                string partNo = selectedRow.Cells[0].Value.ToString();
                foreach (Part part in Inventory.AllParts)
                {
                    if (part.PartID.ToString() == partNo.ToString())
                    {
                        Product product = new Product();
                        product.addAssociatedPart(part, candidateParts);
                    }
                }
            }
        }
        private void addProductDeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            bool isSelected = DataGridViewHelper.IsRowSelected(addProductAssociatedPartsDataGridView);
            if (isSelected)
            {
                DataGridViewRow thisRow = addProductAssociatedPartsDataGridView.SelectedRows[0];
                object cellValue = thisRow.Cells[0].Value;

                foreach (Part part in candidateParts)
                {
                    if (cellValue.ToString() == part.PartID.ToString())
                    {
                        DialogResult result = MessageBox.Show("You are about to delete an associated part. Are you sure?", "Something scary is about to happen...", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Product product = new Product();
                            int partID = part.PartID;
                            candidateParts.Remove(part);
                            addProductAssociatedPartsDataGridView.ClearSelection();
                            break;
                        }
                    }
                }
            }
        }
        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (addProductSearchBox.Text.Length > 0)
            {
                addProductPartsDataGridView.ClearSelection();
                string otherID = addProductSearchBox.Text;
                if (int.TryParse(otherID, out int result))
                {
                    product.lookupAssociatedPart(result, addProductPartsDataGridView);
                }
                else
                {
                    product.lookupAssociatedPart(otherID, addProductPartsDataGridView);
                }
            }
            else
            {
                addProductPartsDataGridView.ClearSelection();
                MessageBox.Show("Please enter text to search");
            }
        }
    }
}
