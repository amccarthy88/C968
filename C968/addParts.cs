using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class addPartsForm : Form
    {
        public addPartsForm()
        {
            InitializeComponent();
        }

        private int autoIncrementValue = 1;
        public Inventory Inventory { get; set; }
        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Visible = true;
            addCompanyLabel.Visible = false;
        }
        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Visible = false;
            addCompanyLabel.Visible = true;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            addIDBox.Text = autoIncrementValue.ToString();
            autoIncrementValue--;

            Properties.Settings.Default.AutoIncrementValue = autoIncrementValue;
            Properties.Settings.Default.Save();
            
            this.Close();
        }
        private void addSaveButton_Click(object sender, EventArgs e)
        {
            InHouse inHouse = new InHouse();
            Outsourced outsourced = new Outsourced();
            if (addInHouseRadio.Checked)
            {
                Inventory.addPart(inHouse, addIDBox.Text, addNameBox.Text, addPriceCostBox.Text, addInventoryBox.Text, addMinBox.Text, addMaxBox.Text, addCompanyNameBox.Text, addInHouseRadio.Checked, this);
                
            }
            else if (addOutsourcedRadio.Checked)
            {
                Inventory.addPart(outsourced, addIDBox.Text, addNameBox.Text, addPriceCostBox.Text, addInventoryBox.Text, addMinBox.Text, addMaxBox.Text, addCompanyNameBox.Text, this);
                
            }
            else
            {
                MessageBox.Show("Please select Inhouse or Outsourced.");
            }
        }
        private void part_template1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoIncrementValue > 0)
            {
                autoIncrementValue = Properties.Settings.Default.AutoIncrementValue;
            }
            else
            {
                autoIncrementValue = 1;
            }
            addIDBox.Text = autoIncrementValue.ToString();
            autoIncrementValue++;

            Properties.Settings.Default.AutoIncrementValue = autoIncrementValue;
            Properties.Settings.Default.Save();
        }
    }
}
