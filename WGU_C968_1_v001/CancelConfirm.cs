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
    public partial class CancelConfirm : Form
    {
        public CancelConfirm()
        {
            InitializeComponent();
        }

    

        private void btn_CancelConfirm_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Owner != null)
                Owner.Close();
        }

        private void btn_CancelConfirm_Cancel_Click(object sender, EventArgs e)
        {
            Form closure = new CancelConfirm();
            closure.Owner = this;
            this.Close();

        }
    }
}
