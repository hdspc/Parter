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

    static class ModPartContainer
    {
        public static BindingList<Part> modpartz = new BindingList<Part>(); 
        public static int currentIndex { get; set; }
    }

    public partial class ModPart : Form
    {

        public ModPart()
        {
            int correctID = ModPartContainer.currentIndex+1;
            int partInfo = ModPartContainer.currentIndex;

            InitializeComponent();
            txt_ModPart_ID.Enabled = false;
            txt_ModPart_ID.Text = correctID.ToString();
            txt_ModPart_Name.Text = Part.partz[partInfo].Name;
            txt_ModPart_Inventory.Text = Part.partz[partInfo].InStock.ToString();
            txt_NewPart_Min.Text = Part.partz[partInfo].Min.ToString();
            txt_ModPart_Max.Text = Part.partz[partInfo].Max.ToString();
            /*
            if (rdo_ModPart_InHouse.Checked )
            {
                txt_ModPart_MachineID = InHousePart.partz[partInfo].

            }*/
        }

        private void rdo_ModPart_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ModPart_MachineID.Text = "Machine ID";
        }

        private void rdo_ModPart_Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ModPart_MachineID.Text = "Company";
        }

        private void btn_ModPart_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
