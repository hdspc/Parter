using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WGU_C968_1_v001
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProdID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public int InStock { get; set; }

        public Product() { }
        public Product(int prodID, string name, int inventory, decimal price, int max, int min)
        {
            ProdID = prodID;
            Name = name;
            InStock = inventory;
            Price = price;
            Max = max;
            Min = min;
        }
        public void AddAssociatedPart(Part P)
        {
            AssociatedParts.Add(P);
        }

        public bool RemoveAssociatedPart(Part P)
        {
            AssociatedParts.Remove(P); 
            return true;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            InHousePart emptyInHousePart = new InHousePart();
            return emptyInHousePart;
        }

    }

 
}
