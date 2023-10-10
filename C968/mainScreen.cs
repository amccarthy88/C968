using System;
using System.ComponentModel;
using System.Data;
using C968;
using System.Windows.Forms;

namespace C968
{
    public partial class C968 : Form
    {
        private Inventory inventory;
        private Product product = new Product();
        private InHouse inHouse = new InHouse();
        private Outsourced Outsourced = new Outsourced();

        public C968()
        {
            InitializeComponent();
            inventory = new Inventory();
            inHouse = new InHouse();
            Outsourced = new Outsourced();

            partsDataGridView.AutoGenerateColumns = false;

            partsDataGridView.Columns[0].DataPropertyName = "PartID";
            partsDataGridView.Columns[1].DataPropertyName = "Name";
            partsDataGridView.Columns[2].DataPropertyName = "InStock";
            partsDataGridView.Columns[3].DataPropertyName = "Price";
            partsDataGridView.Columns[4].DataPropertyName = "Min";
            partsDataGridView.Columns[5].DataPropertyName = "Max";

            partsDataGridView.DataSource = inventory.AllParts;

            productsDataGridView.AutoGenerateColumns = false;

            productsDataGridView.Columns[0].DataPropertyName = "ProductID";
            productsDataGridView.Columns[1].DataPropertyName = "Name";
            productsDataGridView.Columns[2].DataPropertyName = "InStock";
            productsDataGridView.Columns[3].DataPropertyName = "Price";
            productsDataGridView.Columns[4].DataPropertyName = "Min";
            productsDataGridView.Columns[5].DataPropertyName = "Max";

            productsDataGridView.DataSource = inventory.Products;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addPartsForm form = new addPartsForm();
            form.Inventory = inventory;
            form.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            addProductScreen form = new addProductScreen(this.inventory, this.product);
            form.Inventory = inventory;
            form.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = productsDataGridView.SelectedRows[0];
                string productNo = selectedRow.Cells[0].Value.ToString();
                foreach (Product product in inventory.Products)
                {
                    if (product.ProductID.ToString() == productNo)
                    {
                        BindingList<Part> associatedParts = product.AssociatedParts;
                        string data1 = product.ProductID.ToString();
                        string data2 = product.Name.ToString();
                        string data3 = product.Price.ToString();
                        string data4 = product.InStock.ToString();
                        string data5 = product.Min.ToString();
                        string data6 = product.Max.ToString();
                        Product_Template2 modifyProduct = new Product_Template2(this.product, this.inventory, associatedParts, data1, data2, data3, data4, data5, data6);
                        modifyProduct.Product = product;
                        modifyProduct.Inventory = inventory;
                        modifyProduct.Show();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show
                    ("This could have been love at first bite...\n" +
                    "But you need to select a row in the Product table to modify!");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            closeWindowMessage closeWindowMessage = new closeWindowMessage(this);
            closeWindowMessage.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            bool isSelected = DataGridViewHelper.IsRowSelected(partsDataGridView);
            if (isSelected)
            {
                DataGridViewRow thisRow = partsDataGridView.SelectedRows[0];
                object cellValue = thisRow.Cells[0].Value;

                foreach (Part part in inventory.AllParts)
                {
                    if (cellValue.ToString() == part.PartID.ToString())
                    {
                        DialogResult result = MessageBox.Show("You are about to delete a part. Are you sure?", "Something scary is about to happen...", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            inventory.deletePart(part);
                            partsDataGridView.ClearSelection();
                            break;
                        }
                        else
                        {
                        }
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            bool isSelected = DataGridViewHelper.IsRowSelected(productsDataGridView);
            if (isSelected)
            {
                DataGridViewRow thisRow = productsDataGridView.SelectedRows[0];
                object cellValue = thisRow.Cells[0].Value;

                foreach (Product product in inventory.Products)
                {
                    if (cellValue.ToString() == product.ProductID.ToString())
                    {
                        if (product.AssociatedParts.Count > 0)
                        {
                            MessageBox.Show("You cannot delete a product with an associated part.");
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("You are about to delete a product. Are you sure?", "Something scary is about to happen...", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                inventory.removeProduct(product.ProductID);
                                partsDataGridView.ClearSelection();
                                break;
                            }
                            else
                            {
                            }
                        }
                    }
                }
            }
        }
        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = partsDataGridView.SelectedRows[0];
                string partNo = selectedRow.Cells[0].Value.ToString();
                foreach (Part part in inventory.AllParts)
                {
                    if (part.PartID.ToString() == partNo)
                    {
                        string data1 = part.PartID.ToString();
                        string data2 = part.Name.ToString();
                        string data3 = part.Price.ToString();
                        string data4 = part.InStock.ToString();
                        string data5 = part.Min.ToString();
                        string data6 = part.Max.ToString();
                        if (part is InHouse)
                        {
                            InHouse inHouse = (InHouse)part;
                            string data7 = inHouse.MachineID.ToString();
                            modifyPartsScreen modifyPartsForm = new modifyPartsScreen(this.inventory, this.inventory.AllParts, data1, data2, data3, data4, data5, data6, data7);
                            modifyPartsForm.Inventory = inventory;
                            modifyPartsForm.Show();
                        }
                        else if (part is Outsourced)
                        {
                            Outsourced outSourced = (Outsourced)part;
                            string data7 = outSourced.CompanyName.ToString();
                            modifyPartsScreen modifyPartsForm = new modifyPartsScreen(this.inventory, this.inventory.AllParts, data1, data2, data3, data4, data5, data6, data7);
                            modifyPartsForm.Inventory = inventory;
                            modifyPartsForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Something seems to be missing");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }
        private void partsSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                partsSearchButton.PerformClick();
                e.Handled = true;
            }
        }
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            if (partsSearchBox.Text.Length > 0)
            {
                partsDataGridView.ClearSelection();
                string otherID = partsSearchBox.Text;
                if (int.TryParse(otherID, out int result))
                {
                    inventory.LookupPart(result, partsDataGridView);
                }
                else
                {
                    inventory.LookupPart(otherID, partsDataGridView);
                }
            }
            else
            {
                partsDataGridView.ClearSelection();
                MessageBox.Show("Please enter text to search");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                productsDataGridView.ClearSelection();
                string otherID = textBox2.Text;
                if (int.TryParse(otherID, out int result))
                {
                    inventory.lookupProduct(result, productsDataGridView);
                }
                else
                {
                    inventory.lookupProduct(otherID, productsDataGridView);
                }
            }
            else
            {
                MessageBox.Show("Please enter text to search");
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button8.PerformClick();
                e.Handled = true;
            }
        }
        private void C968_Load(object sender, EventArgs e) { }
    }
}