using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public class Product : Inventory
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part) { }
        public void addAssociatedPart(Part part, BindingList<Part> parts) 
        {   
            parts.Add(part);
        }
        public bool removeAssociatedPart(int partID, BindingList<Part> parts) {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    parts.Remove(part);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID) 
                {
                    return part;
                }
            }
            return null;
        }
        public Part lookupAssociatedPart(int partID, DataGridView dataGridView)
        {
            bool isfound = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value?.ToString().ToLower() == partID.ToString().ToLower())
                {
                    row.Selected = true;
                    isfound = true;
                    break;
                }
            }
            if (isfound)
            {
                foreach (Part part in AllParts)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (part.PartID.ToString().ToLower() == row.Cells[0].Value?.ToString().ToLower())
                        {
                            return part;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("No part found.");
                return null;
            }
            return null;
        }
        public Part lookupAssociatedPart(string partID, DataGridView dataGridView)
        {
            bool isfound = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[1].Value?.ToString().ToLower() == partID.ToString().ToLower())
                {
                    row.Selected = true;
                    isfound = true;
                    break;
                }
            }
            if (isfound)
            {
                foreach (Part part in AllParts)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (part.Name.ToString().ToLower() == row.Cells[1].Value?.ToString().ToLower())
                        {
                            return part;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No part found.");
                return null;
            }
            return null;
        }
    }
}
