using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGU_C968_1_v001;

namespace WGU_C968_1_v001
{
    public  abstract class Part
    {
        //public static int qCount;

        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part() { }

        // Part Constructor

        public Part(int ID, string name, double price, int stock, int min, int max)
        {
            PartID = ID;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }

        //FROM WEBINARS


        private static BindingList<Part> Parts = new BindingList<Part>();

        //public static BindingList<Part> partz
        //{
        //    get { return Parts; }
        //    set { Parts = value; }
        //}


    }
}




