using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WGU_C968_1_v001
{

    public partial class AddProduct : Form

    {
        BindingList<Part> associatedParts = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();

            //Data source
            dgv_AddProduct_CandidateParts.DataSource = Inventory.partz;
            //Full resource selection
            dgv_AddProduct_CandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Read only
            dgv_AddProduct_CandidateParts.ReadOnly = true;
            //Multi row select
            dgv_AddProduct_CandidateParts.MultiSelect = false;

            //remove bottom row
            dgv_AddProduct_CandidateParts.AllowUserToAddRows = false;

            //Remove row headers
            dgv_AddProduct_CandidateParts.RowHeadersVisible = false;

            //Auto resize columns (Doesn't work)
            dgv_AddProduct_CandidateParts.AutoResizeColumns();

         

        }

        private void btn_AddProduct_Save_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int InStock;
            double price;
            string name = txt_AddProduct_Name.Text;


            try
            {
                minStock = int.Parse(txt_AddProduct_Min.Text);
                maxStock = int.Parse(txt_AddProduct_Max.Text);
                InStock = int.Parse(txt_AddProduct_Inventory.Text);
                price = double.Parse(txt_AddProduct_Price.Text);

            }
            catch
            {
                MessageBox.Show(
                    "The fields for inventory, price, max, and min must contain only numeric values."
                );
                return;
            }

            if (minStock > maxStock)
            {
                MessageBox.Show("The minimum value must be less than the maximum value.");
                return;
            }

            if (InStock > maxStock || InStock < minStock)
            {
                MessageBox.Show(
                    "A valid inventory value must be within the range of minimum and maximum inventory."
                );
                return;
            }

            Product product = new Product(
                (Inventory.Products.Count + 1),
                name,
                InStock,
                (decimal)price,
                maxStock,
                minStock
            );

            Inventory.AddProduct(product);
            this.Close();

        }

     
    }
}
