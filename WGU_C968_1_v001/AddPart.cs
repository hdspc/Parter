﻿using System;
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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }



        private void btn_AddPart_Cancel_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Cancel text");


            // this.Close();

            Form closure = new CancelConfirm();
            closure.Owner = this;
            closure.ShowDialog();
        }


    }
}
