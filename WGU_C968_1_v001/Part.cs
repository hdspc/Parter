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
    public class Part
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

        public static BindingList<Part> partz
        {
            get { return Parts; }
            set { Parts = value; }
        }

        static Part()
        {
            Parts.Add(new InHousePart(1, "Hammer", 12.99, 3, 6700, 1, 6969));

            Parts.Add(new InHousePart(2, "Saw", 13.99, 4, 9990, 1, 999));

            Parts.Add(new InHousePart(3, "Pliers", 7.99, 25, 9990, 1, 666));

            Parts.Add(new OutsourcedPart(4, "Wrench", 14.99, 15, 9990, 1, "awooga"));

            Parts.Add(new OutsourcedPart(5, "Tape Measure", 8.99, 40, 9990, 1, "hdspc"));
        }
    }
}




