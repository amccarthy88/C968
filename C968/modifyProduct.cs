using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class Product_Template2 : Form
    {
        private Product product;
        public Product Product { get; set; }
        public Product_Template2(Product product, Inventory inventory, BindingList<Part> associatedParts, string data1, string data2, string data3, string data4, string data5, string data6)
        {
            InitializeComponent();
            dataForText1 = data1;
            dataForText2 = data2;
            dataForText3 = data3;
            dataForText4 = data4;
            dataForText5 = data5;
            dataForText6 = data6;
            PopulateTextBox();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns[0].DataPropertyName = "PartID";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[2].DataPropertyName = "InStock";
            dataGridView1.Columns[3].DataPropertyName = "Price";
            dataGridView1.Columns[4].DataPropertyName = "Min";
            dataGridView1.Columns[5].DataPropertyName = "Max";

            dataGridView1.DataSource = inventory.AllParts;

            dataGridView1.AutoGenerateColumns = false;

            dataGridView2.Columns[0].DataPropertyName = "PartID";
            dataGridView2.Columns[1].DataPropertyName = "Name";
            dataGridView2.Columns[2].DataPropertyName = "InStock";
            dataGridView2.Columns[3].DataPropertyName = "Price";
            dataGridView2.Columns[4].DataPropertyName = "Min";
            dataGridView2.Columns[5].DataPropertyName = "Max";

            dataGridView2.DataSource = associatedParts;

        }
        private string dataForText1;
        private string dataForText2;
        private string dataForText3;
        private string dataForText4;
        private string dataForText5;
        private string dataForText6;
        public Inventory Inventory { get; set; }
        private void PopulateTextBox()
        {
            textBox7.Text = dataForText1;
            textBox2.Text = dataForText2;
            textBox3.Text = dataForText4;
            textBox4.Text = dataForText3;
            textBox6.Text = dataForText5;
            textBox5.Text = dataForText6;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Product_Template2_Load(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (textBox1.Text.Length > 0)
            {
                dataGridView1.ClearSelection();
                string otherID = textBox1.Text;
                if (int.TryParse(otherID, out int result))
                {
                    product.lookupAssociatedPart(result, dataGridView1);
                }
                else
                {
                    product.lookupAssociatedPart(otherID, dataGridView1);
                }
            }
            else
            {
                dataGridView1.ClearSelection();
                MessageBox.Show("Please enter text to search");
            }
        }
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(textBox7.Text, out id);
            foreach (Product product in Inventory.Products)
            {
                if (product.ProductID.ToString() == textBox7.Text)
                {
                    Inventory.updateProduct(id, product, textBox7.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text, textBox5.Text, this);
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool isSelected = DataGridViewHelper.IsRowSelected(dataGridView2);
            if (isSelected)
            {
                DataGridViewRow thisRow = dataGridView2.SelectedRows[0];
                object cellValue = thisRow.Cells[0].Value;

                foreach (Part part in Product.AssociatedParts)
                {
                    if (cellValue.ToString() == part.PartID.ToString())
                    {
                        DialogResult result = MessageBox.Show("You are about to delete an associated part. Are you sure?", "Something scary is about to happen...", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //Product product = new Product();
                            Product.removeAssociatedPart(part.PartID, Product.AssociatedParts);
                            dataGridView2.ClearSelection();
                            break;
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string partNo = selectedRow.Cells[0].Value.ToString();
                foreach (Part part in Inventory.AllParts)
                {
                    if (part.PartID.ToString() == partNo.ToString())
                    {
                        Product product = new Product();
                        product.addAssociatedPart(part, Product.AssociatedParts);
                    }
                }
            }
        }
    }
}
