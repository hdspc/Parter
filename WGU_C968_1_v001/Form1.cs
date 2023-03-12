using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
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
            dgv_PartsGrid.DataSource = Part.partz;
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
            ///////////////////////////// ModPart.CellClicked = dgv_PartsGrid.CurrentCell.RowIndex; 

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

            Part.partz.Remove(P);
            dgv_PartsGrid.DataSource = Part.partz;

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
                for (int i = 0; i < Part.partz.Count; i++)
                {
                    if (Part.partz[i].Name.ToUpper().Contains(txt_PartSearch.Text.ToUpper())
                       
                        )
                    {
                        TempList.Add(Part.partz[i]);
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
                    dgv_PartsGrid.DataSource = Part.partz;
                }
            }

        else
            {

                txt_PartSearch.BackColor = System.Drawing.Color.Salmon;
                ;
                dgv_PartsGrid.DataSource = Part.partz;
            }
        } 
    }
}
