using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WGU_C968_1_v001
{
    public partial class Form1 : Form
    {
        private int inx;

        /*Rounded Corners
[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // width of ellipse
int nHeightEllipse // height of ellipse
);*/

        public Form1()
        {
            InitializeComponent();
            /*Rounded corners
            this.FormBorderStyle = FormBorderStyle.Sizable;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            */


            //Data source
            dgv_PartsGrid.DataSource = Inventory.partz;
            //Full resource selection
            dgv_PartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Read only
            dgv_PartsGrid.ReadOnly = true;
            //Multi row select
            dgv_PartsGrid.MultiSelect = false;

            //remove bottom row
            dgv_PartsGrid.AllowUserToAddRows = false;

            //Remove row headers
            dgv_PartsGrid.RowHeadersVisible = false;

            //Auto resize columns (Doesn't work)
            dgv_PartsGrid.AutoResizeColumns();


            dgv_ProductsGrid.DataSource = Inventory.Products;
            dgv_ProductsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ProductsGrid.ReadOnly = true;
            dgv_ProductsGrid.MultiSelect = false;
            dgv_ProductsGrid.AllowUserToAddRows = false;
            dgv_ProductsGrid.RowHeadersVisible = false;
            dgv_ProductsGrid.AutoResizeColumns();

            Inventory.AddPart(new InHousePart(1, "Hammer", 12.99, 3, 6700, 1, 6969));

            Inventory.AddPart(new InHousePart(2, "Saw", 13.99, 4, 9990, 1, 999));

            Inventory.AddPart(new InHousePart(3, "Pliers", 7.99, 25, 9990, 1, 666));

            Inventory.AddPart(new OutsourcedPart(4, "Wrench", 14.99, 15, 9990, 1, "awooga"));

            Inventory.AddPart(new OutsourcedPart(5, "Tape Measure", 8.99, 40, 9990, 1, "hdspc"));

            Inventory.AddProduct(new Product(1, "Contractor Kit", 3, 3222.3m, 23, 1));
            Inventory.AddProduct(new Product(2, "Homeowner's Kit", 30, 32.3m, 123, 1));

        }

        private void btn_AddPart_Click(object sender, EventArgs e)
        {

            // Open Add Part dialog
            Form parts = new AddPart();
            parts.ShowDialog();
        }

        private void CompletedBinding(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear intitial row selection on application open
            dgv_PartsGrid.ClearSelection();
        }

        //Might need this for modify part
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inx = dgv_PartsGrid.CurrentCell.RowIndex;
        }

        private void Btn_PartsModify_Click(object sender, EventArgs e)
        {

            ModPartContainer.currentIndex = dgv_PartsGrid.CurrentCell.RowIndex;

            if (dgv_PartsGrid.CurrentRow == null || !dgv_PartsGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;

            }

            else if (dgv_PartsGrid.CurrentRow.DataBoundItem.GetType() == typeof(WGU_C968_1_v001.InHousePart))
            {
                InHousePart inPart = (InHousePart)dgv_PartsGrid.CurrentRow.DataBoundItem;
                new ModPart(inPart).ShowDialog();
            }

            else
            {
                OutsourcedPart outPart = (OutsourcedPart)dgv_PartsGrid.CurrentRow.DataBoundItem;
                new ModPart(outPart).ShowDialog();
            }


            //////Form parts = new ModPart();
            //////parts.ShowDialog(this);
            //////Part P = dgv_PartsGrid.CurrentRow.DataBoundItem as Part;
        }

        private void Btn_PartsDelete_Click(object sender, EventArgs e)
        {
            if (dgv_PartsGrid.CurrentRow == null || !dgv_PartsGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;

            }

            //Remove part from list
            Part P = dgv_PartsGrid.CurrentRow.DataBoundItem as Part;

            Inventory.DeletePart(P);
            dgv_PartsGrid.DataSource = Inventory.partz;

        }

        private void btn_Main_Exit_Click(object sender, EventArgs e)
        {
            Form closure = new CancelConfirm();
            closure.Owner = this;
            closure.ShowDialog();
        }

        private void btn_PartSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (txt_PartSearch.Text != "")
            {
                for (int i = 0; i < Inventory.partz.Count; i++)
                {
                    if (Inventory.partz[i].Name.ToUpper().Contains(txt_PartSearch.Text.ToUpper())

                       )
                    {
                        TempList.Add(Inventory.partz[i]);
                        found = true;
                    }

                }

                if (found)
                {
                    dgv_PartsGrid.DataSource = TempList;
                }

                if (!found)
                {
                    MessageBox.Show("Nothing found!");
                    dgv_PartsGrid.DataSource = Inventory.partz;
                }
            }

            else
            {

                txt_PartSearch.BackColor = System.Drawing.Color.Salmon;
                ;
                dgv_PartsGrid.DataSource = Inventory.partz;
            }
        }

        private void btn_ProductsAdd_Click(object sender, EventArgs e)
        {
            Form products = new AddProduct();
            products.ShowDialog();
        }

        private void btn_ProductSearch_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempProdList = new BindingList<Product>();
            bool found = false;
            if (txt_ProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(txt_ProductSearch.Text.ToUpper())

                       )
                    {
                        TempProdList.Add(Inventory.Products[i]);
                        found = true;
                    }

                }

                if (found)
                {
                    dgv_ProductsGrid.DataSource = TempProdList;
                }

                if (!found)
                {
                    MessageBox.Show("Nothing found!");
                    dgv_ProductsGrid.DataSource = Inventory.Products;
                }
            }

            else
            {

                txt_ProductSearch.BackColor = System.Drawing.Color.Salmon;
                ;
                dgv_ProductsGrid.DataSource = Inventory.Products;
            }
        }

        private void btn_ProductsModify_Click(object sender, EventArgs e)
        {
            Product inProduct = (Product)dgv_ProductsGrid.CurrentRow.DataBoundItem;

            new ModProduct(inProduct).ShowDialog();
            dgv_ProductsGrid.Refresh();
        }

        private void btn_ProductsDelete_Click(object sender, EventArgs e)
        {
            if (dgv_ProductsGrid.CurrentRow == null || !dgv_ProductsGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;

            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                //Remove part from list
                int P = dgv_ProductsGrid.CurrentRow.Index;
                Product prod = (Product)dgv_ProductsGrid.CurrentRow.DataBoundItem;

                //Inventory.RemoveProduct(P);
                dgv_ProductsGrid.Rows.RemoveAt(P);
                dgv_ProductsGrid.DataSource = Inventory.Products;
            }
            else return;
        }
    }
}
