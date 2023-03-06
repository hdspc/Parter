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
       

        public AddPart()
        {
            InitializeComponent();
            txt_AddPart_ID.Text = Part.partz[0].PartID.ToString();

        }

        private void btn_AddPart_Cancel_Click(object sender, EventArgs e)
        {
            Form closure = new CancelConfirm();
            closure.Owner = this;
            closure.ShowDialog();
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
            //new Part();
            //Console.WriteLine(txt_AddPart_Name.Text);
            //Part.Parts.Add(new Part(100, txt_AddPart_Name.Text, 3332.99, 3, 0, 100));

        }


    }
}
