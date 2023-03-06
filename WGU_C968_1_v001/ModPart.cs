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
    public partial class ModPart : Form
    {
        public ModPart()
        {
            InitializeComponent();
            txt_ModPart_ID.Text = Part.partz[0].PartID.ToString();
        }

    


      

        private void btn_ModPart_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
