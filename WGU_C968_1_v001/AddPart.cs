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
        private int NewPartID = Inventory.partz.Count + 1;

        
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
            int minStock;
            int maxStock;
            int InStock;
            double price;
            int compName;

            try
            {
                minStock = int.Parse(txt_AddPart_Min.Text);
                maxStock = int.Parse(txt_AddPart_Max.Text);
                InStock = int.Parse(txt_AddPart_Inventory.Text);
                price = double.Parse(txt_AddPart_Price.Text);
            }
            catch
            {
                MessageBox.Show(
                    "The fields for inventory, price, max, and min must contain only numeric values."
                );
                return;
            }

            if (minStock > maxStock)
            {
                MessageBox.Show("The minimum value must be less than the maximum value.");
                return;
            }

            if (InStock > maxStock || InStock < minStock)
            {
                MessageBox.Show(
                    "A valid inventory value must be within the range of minimum and maximum inventory."
                );
                return;
            }

            string name = txt_AddPart_Name.Text;

            if (rdo_AddPart_InHouse.Checked)
            {
                try
                {
                    compName = int.Parse(txt_AddPart_MachineID.Text);
                }
                catch
                {
                    MessageBox.Show(
                        "The field for in house parts must contain only numeric values."
                    );
                    return;
                }

                InHousePart inPart = new InHousePart(
                    (Inventory.partz.Count + 1),
                    name,
                    price,
                    InStock,
                    maxStock,
                    minStock,
                    int.Parse(txt_AddPart_MachineID.Text)
                );
                Inventory.AddPart( inPart );
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(
                    NewPartID,
                    name,
                    price,
                    InStock,
                    maxStock,
                    minStock,
                    txt_AddPart_MachineID.Text
                );
                //Part.partz.Add( outPart );
                Inventory.AddPart(outPart);
                // InStock++;
            }

            string NewPartName = txt_AddPart_Name.Text;
            double NewPartPrice = Convert.ToDouble(txt_AddPart_Price.Text);
            int NewPartInventory = Convert.ToInt32(txt_AddPart_Inventory.Text);
            int NewPartMin = Convert.ToInt32(txt_AddPart_Min.Text);
            int NewPartMax = Convert.ToInt32(txt_AddPart_Max.Text);

            //Part.partz.Add(
            //    new Part(NewPartID, NewPartName, NewPartPrice, NewPartInventory, 0, 100)
            //);

            this.Close();
        }

        private void btn_AddPart_Cancel_Click(object sender, EventArgs e)
        {
            Form closure = new CancelConfirm();
            closure.Owner = this;
            closure.ShowDialog();
        }

        //private void txt_AddPart_Name_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txt_AddPart_Name.Text))
        //    {
        //        txt_AddPart_Name.BackColor = System.Drawing.Color.Salmon;

        //        btn_AddPart_Save.Enabled = false;
        //    }
        //}
    }
}
