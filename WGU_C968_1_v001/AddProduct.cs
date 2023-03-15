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
            dgv_AddProduct_CandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_AddProduct_CandidateParts.ReadOnly = true;
            dgv_AddProduct_CandidateParts.MultiSelect = false;
            dgv_AddProduct_CandidateParts.AllowUserToAddRows = false;
            dgv_AddProduct_CandidateParts.RowHeadersVisible = false;
            dgv_AddProduct_CandidateParts.AutoResizeColumns();
            dgv_AddProduct_CandidateParts.ClearSelection();

            txt_AddProduct_ID.Text = Inventory.Products.Count.ToString();

            dgv_AddProduct_PartsAssociated.DataSource = associatedParts;
            dgv_AddProduct_PartsAssociated.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_AddProduct_PartsAssociated.ReadOnly = true;
            dgv_AddProduct_PartsAssociated.MultiSelect = false;
            dgv_AddProduct_PartsAssociated.AllowUserToAddRows = false;
            dgv_AddProduct_PartsAssociated.RowHeadersVisible = false;
            dgv_AddProduct_PartsAssociated.AutoResizeColumns();
            dgv_AddProduct_PartsAssociated.ClearSelection();


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

        private void btn_AddProduct_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddProduct_Search_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (txt_AddProduct_Search.Text != "")
            {
                for (int i = 0; i < Inventory.partz.Count; i++)
                {
                    if (Inventory.partz[i].Name.ToUpper().Contains(txt_AddProduct_Search.Text.ToUpper())

                       )
                    {
                        TempList.Add(Inventory.partz[i]);
                        found = true;
                    }

                }

                if (found)
                {
                    dgv_AddProduct_CandidateParts.DataSource = TempList;
                }

                if (!found)
                {
                    MessageBox.Show("Nothing found!");
                    dgv_AddProduct_CandidateParts.DataSource = Inventory.partz;
                }
            }

            else
            {

                txt_AddProduct_Search.BackColor = System.Drawing.Color.Salmon;
                ;
                dgv_AddProduct_CandidateParts.DataSource = Inventory.partz;
            }
        }

        private void btn_AddAssociatedProduct_Add_Click(object sender, EventArgs e)
        {
            if (dgv_AddProduct_CandidateParts.CurrentRow == null || !dgv_AddProduct_CandidateParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;

            }
            else
            {
                Part partToAdd = (Part)dgv_AddProduct_CandidateParts.CurrentRow.DataBoundItem;
                associatedParts.Add(partToAdd);
                dgv_AddProduct_PartsAssociated.DataSource = associatedParts;
            }

        }

        private void btn_AddProduct_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_AddProduct_PartsAssociated.CurrentRow == null || !dgv_AddProduct_PartsAssociated.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;

            }
            else
            {
                Part partToRemove = (Part)dgv_AddProduct_PartsAssociated.CurrentRow.DataBoundItem;
               // associatedParts.Add(partToAdd);
               // dgv_AddProduct_PartsAssociated.DataSource = associatedParts;
               associatedParts.Remove(partToRemove);
            }
        }
    }
}
