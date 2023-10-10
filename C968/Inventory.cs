using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public class Inventory 
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        InHouse inhouse = new InHouse
        {
            PartID = 01,
            Name = "Ribcage",
            InStock = 5,
            Price = 12.99M,
            Min = 1,
            Max = 10,
            MachineID = 102
        };

        Outsourced outsourced = new Outsourced
        {
            PartID = 02,
            Name = "Humerus",
            InStock = 13,
            Price = 13.66M,
            Min = 1,
            Max = 20,
            CompanyName = "Spooky's Scary Skeletons"
        };

        /*Product Product { get; set; }
        
        Product product = new Product
        {
            ProductID = 1,
            Name = "A Whole Skeleton",
            InStock= 14,
            Min = 1,
            Max = 20,
        };*/
        public Inventory()
        {
            AllParts = new BindingList<Part>();
            Products = new BindingList<Product>();
            AllParts.Add(inhouse); AllParts.Add(outsourced);
        }
        //--PARTS METHODS--
        public void addPart(Part part) 
        {
            AllParts.Add(part);
            
        }
        public void addPart(Outsourced outsourced, string id, string name, string price, string inventory, string min, string max, string idOrCompany, Form form)
        {
            
            Outsourced outsourcedPart = new Outsourced();

            string userInputID = id;
            string userInputName = name;
            string userInputPrice = price;
            string userInStock = inventory;
            string userMin = min;
            string userMax = max;
            string companyName = idOrCompany;
            int partID;
            decimal partPrice;
            int inStock;
            int inMin;
            int inMax;

            if (int.TryParse(userInputID, out partID) &&
                decimal.TryParse(userInputPrice, out partPrice) &&
                (userInputPrice.Length > 0))
            {
                 if (
                int.TryParse(userInStock, out inStock) &&
                (userInStock.Length > 0))
                {
                    if (int.TryParse(userMin, out inMin) &&
                        (userMin.Length > 0))
                    {
                        if(int.TryParse(userMax, out inMax) &&
                                (userMin.Length > 0))
                        {
                            {
                                outsourcedPart.PartID = partID;
                                outsourcedPart.Name = userInputName;
                                outsourcedPart.Price = partPrice;
                                outsourcedPart.InStock = inStock;
                                outsourcedPart.CompanyName = companyName;
                                if (inMax > inMin)
                                {
                                    outsourcedPart.Min = inMin;
                                    outsourcedPart.Max = inMax;
                                    if (inStock > inMin && inStock < inMax)
                                    {
                                        if (name.Length > 0)
                                        {
                                            if (companyName.Length > 0)
                                            {
                                                AllParts.Add(outsourcedPart);
                                                form.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a company name.");
                                            }
                                            
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a name.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Current stock should be greater than min and less than max.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Max must be greater than Min");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please indicate maximum stock with a valid integer.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please indicate minimum stock with a valid integer.");
                    }
                
                }
                 else
                {
                    MessageBox.Show("Please indicate how many are in stock with a valid integer.");
                }
                
            }
            else
            {
                MessageBox.Show("Please enter a valid price in the price box.");
            }
        }
        public void addPart(InHouse inhouse, string id, string name, string price, string inventory,  string min, string max, string idOrCompany, bool inhouseChecked, Form form)
        {
            InHouse inHousePart = new InHouse();

            string userInputID = id;
            string userInputName = name;
            string userInputPrice = price;
            string userInStock = inventory;
            string userMin = min;
            string userMax = max;
            string userMachineID = idOrCompany;
            int partID;
            decimal partPrice;
            int inStock;
            int inMin;
            int inMax;
            int machineID;

            if (int.TryParse(userInputID, out partID) &&
                decimal.TryParse(userInputPrice, out partPrice) &&
                (userInputPrice.Length > 0))
            {
                if (
               int.TryParse(userInStock, out inStock) &&
               (userInStock.Length > 0))
                {
                    if (int.TryParse(userMin, out inMin) &&
                        (userMin.Length > 0))
                    {
                        if (int.TryParse(userMax, out inMax) &&
                                (userMin.Length > 0))
                        {
                            {
                                inhouse.PartID = partID;
                                inhouse.Name = userInputName;
                                inhouse.Price = partPrice;
                                inhouse.InStock = inStock;
                                
                                if (inMax > inMin)
                                {
                                    inhouse.Min = inMin;
                                    inhouse.Max = inMax;
                                    if (inStock > inMin && inStock < inMax)
                                    {
                                        if (name.Length > 0)
                                        {
                                            if (int.TryParse(userMachineID, out machineID) &&
                                                (userMachineID.Length > 0)) 
                                            {
                                                inhouse.MachineID = machineID;
                                                AllParts.Add(inhouse);
                                                form.Close();

                                            }
                                            
                                            else
                                            {
                                                MessageBox.Show("Please enter a Machine ID with a valid Integer.");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a name.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Current stock should be greater than min and less than max.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Max must be greater than Min");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please indicate maximum stock with a valid integer.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please indicate minimum stock with a valid integer.");
                    }

                }
                else
                {
                    MessageBox.Show("Please indicate how many are in stock with a valid integer.");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid price in the price box.");
            }


        }
        public bool deletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }
        public void updatePart(int partID, Part part) { }
        public void updatePart(int partID, Part part, string nameBox, string inventoryBox, string priceBox, string minBox, string maxBox, string machineCompanyBox, bool inHouseChecked, bool outsourcedChecked, Form form)
        {
            if (part.PartID.ToString() == partID.ToString())
            {
                int inventory;
                decimal price;
                int min;
                int max;
                int machineID;

                if (part is InHouse && inHouseChecked)
                {
                    InHouse inHouse = (InHouse)part;
                    if (int.TryParse(inventoryBox, out inventory) &&
                        (inventoryBox.Length > 0))
                    {
                        if (decimal.TryParse(priceBox, out price) &&
                            (priceBox.Length > 0))
                        {
                            if (int.TryParse(minBox, out min) &&
                                (minBox.Length > 0))
                            {
                                if (int.TryParse(maxBox, out max) &&
                                    (maxBox.Length > 0))
                                {
                                    if (int.TryParse(machineCompanyBox, out machineID) &&
                                        (machineCompanyBox.Length > 0))
                                    {
                                        inHouse.PartID = partID;
                                        inHouse.Name = nameBox;

                                        inHouse.Price = price;

                                        inHouse.MachineID = machineID;
                                        if (max > min)
                                        {
                                            inHouse.Min = min;
                                            inHouse.Max = max;
                                            if (inventory > min && inventory < max)
                                            {
                                                inHouse.InStock = inventory;
                                                if (nameBox.Length > 0)
                                                {
                                                    AllParts.ResetItem(AllParts.IndexOf(part));
                                                    form.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid name.");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Current stock must be less than max and greater than min.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Max must be greater than min.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid integer for Machine ID.");
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid maximum stock.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid minimum stock.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid price.");
                        }
                        
                    }
                    else 
                    {
                        MessageBox.Show("Please enter a valid integer number in stock.");
                    }
                }
                else if (part is Outsourced && outsourcedChecked)
                {
                    Outsourced outsourced = (Outsourced)part;
                    if (int.TryParse(inventoryBox, out inventory) &&
                        (inventoryBox.Length > 0))
                    {
                        if (decimal.TryParse(priceBox, out price) &&
                            (priceBox.Length > 0))
                        {
                            if (int.TryParse(minBox, out min) &&
                                (minBox.Length > 0))
                            {
                                if (int.TryParse(maxBox, out max) &&
                                    (maxBox.Length > 0))
                                {
                                    if (machineCompanyBox.Length > 0)
                                    {
                                        outsourced.PartID = partID;
                                        outsourced.Name = nameBox;

                                        outsourced.Price = price;

                                        outsourced.CompanyName = machineCompanyBox;
                                        if (max > min)
                                        {
                                            outsourced.Min = min;
                                            outsourced.Max = max;
                                            if (inventory > min && inventory < max)
                                            {
                                                outsourced.InStock = inventory;
                                                if (nameBox.Length > 0)
                                                {
                                                    AllParts.ResetItem(AllParts.IndexOf(part));
                                                    form.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid name.");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Current stock must be less than max and greater than min.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Max must be greater than min.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid company name.");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid maximum stock.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid minimum stock.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid price.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer number in stock.");
                    }
                }
                else if (part is InHouse && outsourcedChecked)
                {
                    Outsourced outsourced = new Outsourced();
                    if (int.TryParse(inventoryBox, out inventory) &&
                        (inventoryBox.Length > 0))
                    {
                        if (decimal.TryParse(priceBox, out price) &&
                            (priceBox.Length > 0))
                        {
                            if (int.TryParse(minBox, out min) &&
                                (minBox.Length > 0))
                            {
                                if (int.TryParse(maxBox, out max) &&
                                    (maxBox.Length > 0))
                                {
                                    if (machineCompanyBox.Length > 0)
                                    {
                                        outsourced.PartID = partID;
                                        outsourced.Name = nameBox;

                                        outsourced.Price = price;

                                        outsourced.CompanyName = machineCompanyBox;
                                        if (max > min)
                                        {
                                            outsourced.Min = min;
                                            outsourced.Max = max;
                                            if (inventory > min && inventory < max)
                                            {
                                                outsourced.InStock = inventory;
                                                if (nameBox.Length > 0)
                                                {
                                                    AllParts.Add(outsourced);
                                                    AllParts.Remove(part);
                                                    form.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid name.");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Current stock must be less than max and greater than min.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Max must be greater than min.");
                                        }
                                    }
                                    

                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid maximum stock.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid minimum stock.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid price.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer number in stock.");
                    }
                }
                else if (part is Outsourced && inHouseChecked)
                {
                    InHouse inHouse = new InHouse();
                    if (int.TryParse(inventoryBox, out inventory) &&
                        (inventoryBox.Length > 0))
                    {
                        if (decimal.TryParse(priceBox, out price) &&
                            (priceBox.Length > 0))
                        {
                            if (int.TryParse(minBox, out min) &&
                                (minBox.Length > 0))
                            {
                                if (int.TryParse(maxBox, out max) &&
                                    (maxBox.Length > 0))
                                {
                                    if (int.TryParse(machineCompanyBox, out machineID) &&
                                        (machineCompanyBox.Length > 0))
                                    {
                                        inHouse.PartID = partID;
                                        inHouse.Name = nameBox;

                                        inHouse.Price = price;

                                        inHouse.MachineID = machineID;
                                        if (max > min)
                                        {
                                            inHouse.Min = min;
                                            inHouse.Max = max;
                                            if (inventory > min && inventory < max)
                                            {
                                                inHouse.InStock = inventory;
                                                if (nameBox.Length > 0)
                                                {
                                                    AllParts.Add(inHouse);
                                                    AllParts.Remove(part);
                                                    form.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter a valid name.");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Current stock must be less than max and greater than min.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Max must be greater than min.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid integer for Machine ID.");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid maximum stock.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid minimum stock.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid price.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer number in stock.");
                    }
                }
            }
        }
        public Part LookupPart(int partID) 
        { 
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID) return part;
            }
            return null;  
        }
        public Part LookupPart(int partID, DataGridView dataGridView)
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
        public Part LookupPart(string partID, DataGridView dataGridView)
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
        //--PRODUCTS METHODS--
        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public void addProduct(Product product, string id, string name, string price, string inventory, string min, string max, Form form)
        {
            string userInputID = id;
            string userInputName = name;
            string userInputPrice = price;
            string userInStock = inventory;
            string userMin = min;
            string userMax = max;
            int partID;
            decimal partPrice;
            int inStock;
            int inMin;
            int inMax;
            int machineID;

            if (int.TryParse(userInputID, out partID))
            {
                if (decimal.TryParse(userInputPrice, out partPrice) &&
                    (userInputPrice.Length > 0))
                {
                    if (int.TryParse(userInStock, out inStock) &&
                        (userInStock.Length > 0))
                    {
                        if (int.TryParse(userMin, out inMin) &&
                            userMin.Length > 0)
                        {
                            if (int.TryParse(userMax, out inMax) &&
                                userMax.Length > 0)
                            {
                                    product.ProductID = partID;
                                    product.Name = userInputName;
                                    product.Price = partPrice;
                                    if (inMax > inMin)
                                    {
                                        product.Min = inMin;
                                        product.Max = inMax;
                                        if (inStock > inMin && inStock < inMax)
                                        {
                                            product.InStock = inStock;
                                            if (name.Length > 0)
                                            {
                                                product.Name = name;
                                                Products.Add(product);
                                                form.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a valid name.");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Current stock must be less than max and greater than min.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Max must be greater than Min");
                                    }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid integer for maximum number in stock.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid integer for minimum number in stock.");
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer for number in stock.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer for price.");
                }
            } 
                
            
        }
        public bool removeProduct(int ProductID) 
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == ProductID)
                {
                    Products.Remove(product);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public Product lookupProduct(int productID)
        {
            return null;
        }
        public Product lookupProduct(int productID, DataGridView dataGridView)
        {
            bool isfound = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value?.ToString().ToLower() == productID.ToString().ToLower())
                {
                    row.Selected = true;
                    isfound = true;
                    break;
                }
            }
            if (isfound)
            {
                foreach (Product product in Products)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (product.ProductID.ToString().ToLower() == row.Cells[0].Value?.ToString().ToLower())
                        {
                            return product;
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
                MessageBox.Show("No product found.");
                return null;
            }
            return null;
        }
        public Product lookupProduct(string productID, DataGridView dataGridView)
        {
            bool isfound = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[1].Value?.ToString().ToLower() == productID.ToString().ToLower())
                {
                    row.Selected = true;
                    isfound = true;
                    break;
                }
            }
            if (isfound)
            {
                foreach (Product product in Products)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (product.Name.ToString().ToLower() == row.Cells[1].Value?.ToString().ToLower())
                        {
                            return product;
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
                MessageBox.Show("No product found.");
                return null;
            }
            return null;
        }
        public void updateProduct(int productID, Product product, string productid, string nameBox, string inventoryBox, string priceBox, string minBox, string maxBox, Form form)
        {
            if (product.ProductID.ToString() == productid.ToString())
            {
                BindingList<Part> parts;
                int inventory;
                decimal price;
                int min;
                int max;
                int machineID;
                if (int.TryParse(inventoryBox, out inventory) &&
                        (inventoryBox.Length > 0))
                {
                    if (decimal.TryParse(priceBox, out price) &&
                        (priceBox.Length > 0))
                    {
                        if (int.TryParse(minBox, out min) &&
                            (minBox.Length > 0))
                        {
                            if (int.TryParse(maxBox, out max) &&
                                (maxBox.Length > 0))
                            {
                                    product.ProductID = productID;
                                    product.Name = nameBox;

                                    product.Price = price;

                                    if (max > min)
                                    {
                                        product.Min = min;
                                        product.Max = max;
                                        if (inventory > min && inventory < max)
                                        {
                                            product.InStock = inventory;
                                            if (nameBox.Length > 0)
                                            {
                                                Products.ResetItem(Products.IndexOf(product));
                                                form.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a valid name.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Current stock must be less than max and greater than min.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Max must be greater than min.");
                                    }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid maximum stock.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid minimum stock.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid price.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer number in stock.");
                }
            }
            
        }
    }
}
