using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WGU_C968_1_v001
{

    public partial class ModProduct : Form

    {
        BindingList<Part> associatedParts = new BindingList<Part>();

        public ModProduct(Product inProduct)
        {
            InitializeComponent();

            //Candidate Parts
            dgv_ModProduct_CandidateParts.DataSource = Inventory.partz;
            dgv_ModProduct_CandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ModProduct_CandidateParts.ReadOnly = true;
            dgv_ModProduct_CandidateParts.MultiSelect = false;
            dgv_ModProduct_CandidateParts.AllowUserToAddRows = false;
            dgv_ModProduct_CandidateParts.RowHeadersVisible = false;
            dgv_ModProduct_CandidateParts.AutoResizeColumns();
            dgv_ModProduct_CandidateParts.ClearSelection();

            // Parts Associated

            dgv_ModProduct_PartsAssociated.DataSource = associatedParts;
            dgv_ModProduct_PartsAssociated.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ModProduct_PartsAssociated.ReadOnly = true;
            dgv_ModProduct_PartsAssociated.MultiSelect = false;
            dgv_ModProduct_PartsAssociated.AllowUserToAddRows = false;
            dgv_ModProduct_PartsAssociated.RowHeadersVisible = false;
            dgv_ModProduct_PartsAssociated.AutoResizeColumns();
            dgv_ModProduct_PartsAssociated.ClearSelection();

            //Autofill Form Data

                txt_ModProduct_ID.Enabled = false;
                txt_ModProduct_ID.Text = inProduct.ProdID.ToString();
                txt_ModProduct_Name.Text = inProduct.Name;
                txt_ModProduct_Price.Text = inProduct.Price.ToString();
                txt_ModProduct_Inventory.Text = inProduct.InStock.ToString();
                txt_ModProduct_Min.Text = inProduct.Min.ToString();
                txt_ModProduct_Max.Text = inProduct.Max.ToString();

                foreach (Part part in inProduct.AssociatedParts)
                {
                    associatedParts.Add(part);
                }
                var botTable = new BindingSource();
                botTable.DataSource = associatedParts;
                dgv_ModProduct_PartsAssociated.DataSource = botTable;


        }

        private void btn_ModProduct_Save_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int InStock;
            double price;
            string name = txt_ModProduct_Name.Text;


            try
            {
                minStock = int.Parse(txt_ModProduct_Min.Text);
                maxStock = int.Parse(txt_ModProduct_Max.Text);
                InStock = int.Parse(txt_ModProduct_Inventory.Text);
                price = double.Parse(txt_ModProduct_Price.Text);

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
            int id = int.Parse(txt_ModProduct_ID.Text);

            Product product = new Product(
                Int32.Parse(txt_ModProduct_ID.Text),
                name,
                InStock,
                (decimal)price,
                maxStock,
                minStock
            );

            foreach (Part part in associatedParts)
            {
                product.AddAssociatedPart(part);
            }

            Inventory.UpdateProduct(product.ProdID, product);

            this.Close();

        }

        private void btn_ModProduct_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ModProduct_Search_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (txt_ModProduct_Search.Text != "")
            {
                for (int i = 0; i < Inventory.partz.Count; i++)
                {
                    if (Inventory.partz[i].Name.ToUpper().Contains(txt_ModProduct_Search.Text.ToUpper())

                       )
                    {
                        TempList.Add(Inventory.partz[i]);
                        found = true;
                    }

                }

                if (found)
                {
                    dgv_ModProduct_CandidateParts.DataSource = TempList;
                }

                if (!found)
                {
                    MessageBox.Show("Nothing found!");
                    dgv_ModProduct_CandidateParts.DataSource = Inventory.partz;
                }
            }

            else
            {

                txt_ModProduct_Search.BackColor = System.Drawing.Color.Salmon;
                ;
                dgv_ModProduct_CandidateParts.DataSource = Inventory.partz;
            }
        }

        private void btn_AddAssociatedProduct_Add_Click(object sender, EventArgs e)
        {
            if (dgv_ModProduct_CandidateParts.CurrentRow == null || !dgv_ModProduct_CandidateParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;

            }
            else
            {
                Part partToAdd = (Part)dgv_ModProduct_CandidateParts.CurrentRow.DataBoundItem;
                associatedParts.Add(partToAdd);
                dgv_ModProduct_PartsAssociated.DataSource = associatedParts;
            }

        }

        private void btn_ModProduct_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_ModProduct_PartsAssociated.CurrentRow == null || !dgv_ModProduct_PartsAssociated.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part partToRemove = (Part)dgv_ModProduct_PartsAssociated.CurrentRow.DataBoundItem;
                associatedParts.Remove(partToRemove);
            }
            else return;


         
        }
    }
}
