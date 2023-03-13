using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WGU_C968_1_v001
{

    public partial class ModPart : Form
    {
        private int NewPartID = Inventory.partz.Count + 1;


        //ORIGINAL

        //public ModPart()
        //{
        //    int partInfo = ModPartContainer.currentIndex;

        //    InitializeComponent();
        //    txt_ModPart_ID.Enabled = false;
        //    txt_ModPart_ID.Text = Inventory.partz[partInfo].PartID.ToString();
        //    txt_ModPart_Name.Text = Inventory.partz[partInfo].Name;
        //    txt_ModPart_Inventory.Text = Inventory.partz[partInfo].InStock.ToString();
        //    txt_NewPart_Min.Text = Inventory.partz[partInfo].Min.ToString();
        //    txt_ModPart_Max.Text = Inventory.partz[partInfo].Max.ToString();


        //}



        public ModPart(InHousePart inPart)
        {
           // int partInfo = ModPartContainer.currentIndex;

            InitializeComponent();
            txt_ModPart_ID.Enabled = false;
            txt_ModPart_ID.Text = inPart.PartID.ToString();
            txt_ModPart_Name.Text = inPart.Name;
            txt_ModPart_Price.Text = inPart.Price.ToString();
            txt_ModPart_Inventory.Text = inPart.InStock.ToString();
            txt_ModPart_Min.Text = inPart.Min.ToString();
            txt_ModPart_Max.Text = inPart.Max.ToString();
            txt_ModPart_MachineID.Text = inPart.MachineID.ToString();

        }
        
    
        public ModPart(OutsourcedPart outPart)
        {

            InitializeComponent();
            txt_ModPart_ID.Enabled = false;
            txt_ModPart_ID.Text = outPart.PartID.ToString();
            txt_ModPart_Name.Text = outPart.Name;
            txt_ModPart_Price.Text = outPart.Price.ToString();
            txt_ModPart_Inventory.Text = outPart.InStock.ToString();
            txt_ModPart_Min.Text = outPart.Min.ToString();
            txt_ModPart_Max.Text = outPart.Max.ToString();
            txt_ModPart_MachineID.Text = outPart.CompName.ToString();

            rdo_ModPart_Outsourced.Checked = true;

        }

    

  

        private void btn_ModPart_Save_Click(object sender, EventArgs e)
        
            {

                int partInfo = ModPartContainer.currentIndex;

            int minStock;
                int maxStock;
                int InStock;
                double price;
                int compName;

                try
                {
                    minStock = int.Parse(txt_ModPart_Min.Text);
                    maxStock = int.Parse(txt_ModPart_Max.Text);
                    InStock = int.Parse(txt_ModPart_Inventory.Text);
                    price = double.Parse(txt_ModPart_Price.Text);
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

                string name = txt_ModPart_Name.Text;

                if (rdo_ModPart_InHouse.Checked)
                {
                    try
                    {
                        compName = int.Parse(txt_ModPart_MachineID.Text);
                    }
                    catch
                    {
                        MessageBox.Show(
                            "The field for in house parts must contain only numeric values."
                        );
                        return;
                    }

                    InHousePart inPart = new InHousePart(
                        Inventory.partz[partInfo].PartID,
                        name,
                        price,
                        InStock,
                        maxStock,
                        minStock,
                        int.Parse(txt_ModPart_MachineID.Text)
                    );

                    //DELETE original part
                    Part P = Inventory.partz[partInfo] as Part;
                    Inventory.partz.Remove(P);
                // REPLACE with a new one
                    Inventory.partz.Add(inPart);
                }







                else
                {
                    OutsourcedPart outPart = new OutsourcedPart(
                        Inventory.partz[partInfo].PartID,
                        name,
                        price,
                        InStock,
                        maxStock,
                        minStock,
                        txt_ModPart_MachineID.Text
                    );
                    Part P = Inventory.partz[partInfo] as Part;
                    Inventory.partz.Remove(P);

                Inventory.partz.Add(outPart);
                    // InStock++;
                }

                string NewPartName = txt_ModPart_Name.Text;
                double NewPartPrice = Convert.ToDouble(txt_ModPart_Price.Text);
                int NewPartInventory = Convert.ToInt32(txt_ModPart_Inventory.Text);
                int NewPartMin = Convert.ToInt32(txt_ModPart_Min.Text);
                int NewPartMax = Convert.ToInt32(txt_ModPart_Max.Text);
            

                this.Close();
            }

        

        private void btn_ModPart_Cancel_Click(object sender, EventArgs e)
        {
            Form closure = new CancelConfirm();
            closure.Owner = this;
            closure.ShowDialog();
        }

        private void rdo_ModPart_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ModPart_MachineID.Text = "Machine ID";
        }

        private void rdo_ModPart_Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ModPart_MachineID.Text = "Company Name";

        }
    }


    static class ModPartContainer
    {
        public static BindingList<Part> modpartz = new BindingList<Part>();
        public static int currentIndex { get; set; }
    }


}
