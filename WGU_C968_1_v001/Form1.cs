using System;
using System.Windows.Forms;

namespace WGU_C968_1_v001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Data source
            dgv_PartsGrid.DataSource = Part.Parts;
            //Full resource selection
            dgv_PartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Read only
            dgv_PartsGrid.ReadOnly = true;
            //Multi row select
            dgv_PartsGrid.MultiSelect = false;

            //remove bottom row
            dgv_PartsGrid.AllowUserToAddRows = false;
        }



   
        private void btn_AddPart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hello");
            System.Diagnostics.Debug.WriteLine("This is a adtaagataagagaglog");
            
            // Open Add Part dialog
            Form parts = new AddPart();  
            parts.ShowDialog();
        }

        private void CompletedBinding(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear intitial row selection on application open
            dgv_PartsGrid.ClearSelection();
        }

        //Probably don't need this
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //jMessageBox.Show(dgv_PartsGrid.CurrentCell.Value + " was clicked");
        }

        private void Btn_PartsModify_Click(object sender, EventArgs e)
        {
            if (dgv_PartsGrid.CurrentRow == null || !dgv_PartsGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected!");
                return;
                
            }

            Part P = dgv_PartsGrid.CurrentRow.DataBoundItem as Part;
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

            Part.Parts.Remove(P);
        }

        private void btn_Main_Exit_Click(object sender, EventArgs e)
        {
            Form closure = new CancelConfirm();
            closure.Owner = this;
            closure.ShowDialog();
        }
    }
}
