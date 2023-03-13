
using System.ComponentModel;
using System.Windows.Forms;

namespace WGU_C968_1_v001
{
     class Inventory
     {
        public static BindingList<Product> Products = new BindingList<Product>();

        private static BindingList<Part> Parts = new BindingList<Part>();

        public static BindingList<Part> partz
        {
            get { return Parts; }
            set { Parts = value; }
        }



        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        public static bool RemoveProduct(int prodID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (prodID == prod.ProdID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Removal failed.");
                    return success = false;
                }
            }
            return success;
        }

        public static Product LookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProdID == prodID)
                {
                    return prod;
                }
            }
            Product emptyProduct = new WGU_C968_1_v001.Product();
            return emptyProduct;
        }

        public static void UpdateProduct(int prodID, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProdID == prodID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.InStock = updatedProduct.InStock;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }

        public static void AddPart(Part part)
        {
            partz.Add(part);
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part P in partz)
            {
                if (P.PartID == partID)
                {
                    return P;
                }
            }
            Part emptyPart = new InHousePart();
            return emptyPart;
        }

        public static bool DeletePart(Part P)
        {
         

               partz.Remove(P);
                return true;
          
        }

              public static void UpdatePart(Part partID, Part part)
        {
            DeletePart(partID);
            AddPart(part);
        }




    }
}
