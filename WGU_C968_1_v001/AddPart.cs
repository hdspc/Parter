using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WGU_C968_1_v001
{
    public partial class AddPart : Form
    {
        int NewPartID = Part.partz.Count + 1;

        public AddPart()
        {
            InitializeComponent();

            //  txt_AddPart_ID.Text = Part.partz[0].PartID.ToString();
            txt_AddPart_ID.Text = NewPartID.ToString();
        }

        private void rdo_AddPart_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_AddPart_MachineID.Text = "Machine ID";
        }

        private void rdo_AddPart_Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_AddPart_MachineID.Text = "Company";
        }

        public void btn_AddPart_Save_Click(object sender, EventArgs e)
        {
            string NewPartName = txt_AddPart_Name.Text;
            double NewPartPrice = Convert.ToDouble(txt_AddPart_Price.Text);
            int NewPartInventory = Convert.ToInt32(txt_AddPart_Inventory.Text);
            int NewPartMin = Convert.ToInt32(txt_AddPart_Min.Text);
            int NewPartMax = Convert.ToInt32(txt_AddPart_Max.Text);

            Part.partz.Add(
                new Part(NewPartID, NewPartName, NewPartPrice, NewPartInventory, 0, 100)
            );

            this.Close();
        }

        private void btn_AddPart_Cancel_Click(object sender, EventArgs e)
        {
            Form closure = new CancelConfirm();
            closure.Owner = this;
            closure.ShowDialog();
        }
    }
}
