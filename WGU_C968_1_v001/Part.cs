using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Parts.Add(new Part(1, "Hammer", 12.99, 3, 0, 100));

            Parts.Add(new Part(2, "Saw", 13.99, 4, 0, 10));

            Parts.Add(new Part(3, "Pliers", 7.99, 25, 0, 150));

            Parts.Add(new Part(4, "Wrench", 14.99, 15, 0, 50));

            Parts.Add(new Part(5, "Tape Measure", 8.99, 40, 0, 100));
        }
    }
}
