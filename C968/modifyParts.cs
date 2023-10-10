using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class modifyPartsScreen : Form
    {
        private void part_template2_Load(object sender, EventArgs e) { }
        private string dataForText1;
        private string dataForText2;
        private string dataForText3;
        private string dataForText4;
        private string dataForText5;
        private string dataForText6;
        private string dataForText7;

        public modifyPartsScreen(Inventory inventory, BindingList<Part> partList, string data1, string data2, string data3, string data4, string data5, string data6, string data7)
        {
            InitializeComponent();
            dataForText1 = data1;
            dataForText2 = data2;
            dataForText3 = data3;
            dataForText4 = data4;
            dataForText5 = data5;
            dataForText6 = data6;
            dataForText7 = data7;
            PopulateTextBox();
            foreach (Part part in inventory.AllParts)
            {
                if (part.PartID.ToString() == idBox.Text)
                {
                    if (part is InHouse)
                    {
                        inHouseRadio.Checked = true;
                        break;
                    }
                    else if (part is Outsourced)
                    {
                        outsourcedRadio.Checked = true;
                        break;
                    }
                }
            }
        }
        public Inventory Inventory { get; set; }
        private void PopulateTextBox()
        {
            idBox.Text = dataForText1;
            nameBox.Text = dataForText2;
            inventoryBox.Text = dataForText4;
            priceBox.Text = dataForText3;
            addMinBox.Text = dataForText5;
            nameMachineBox.Text = dataForText7;
            addMaxBox.Text = dataForText6;
        }
        
        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            label9.Visible = false;
        }
        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
            label9.Visible = true;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            int id;

            int.TryParse(idBox.Text, out id);
            if (inHouseRadio.Checked || outsourcedRadio.Checked)
            {
                foreach (Part part in Inventory.AllParts)
                {
                    if (part.PartID.ToString() == idBox.Text)
                    {
                        if (part is InHouse)
                        {
                            InHouse inHouse = (InHouse)part;
                            Inventory.updatePart(id, inHouse, nameBox.Text, inventoryBox.Text, priceBox.Text, addMinBox.Text, addMaxBox.Text, nameMachineBox.Text, inHouseRadio.Checked, outsourcedRadio.Checked, this);
                            break;
                        }
                        else if (part is Outsourced)
                        {
                            Outsourced outsourced = (Outsourced)part;
                            Inventory.updatePart(id, outsourced, nameBox.Text, inventoryBox.Text, priceBox.Text, addMinBox.Text, addMaxBox.Text, nameMachineBox.Text, inHouseRadio.Checked, outsourcedRadio.Checked, this);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select In-House or Radio");
            }
        }
    }
}
