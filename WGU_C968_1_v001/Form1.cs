using System;
using System.Windows.Forms;

namespace WGU_C968_1_v001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgv_PartsGrid.DataSource = Part.Parts;
        }



   
        private void btn_AddPart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("This is a adtaagataagagaglog");
            
            Form parts = new AddPart(); //this is the change, code for redirect  
            parts.ShowDialog();
        }

     

      
    }
}
