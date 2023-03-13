using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //var candidateParts = new BindingSource();
            //candidateParts.DataSource = Inventory.partz;
            //dgv_AddProduct_CandidateParts.DataSource = Inventory.partz;

            //var partsAssociated = new BindingSource();
            //partsAssociated.DataSource = associatedParts;
            //dgv_AddProduct_PartsAssociated.DataSource = partsAssociated;

        }

        private void btn_AddProduct_Save_Click(object sender, EventArgs e)
        {

        }

     
    }
}
