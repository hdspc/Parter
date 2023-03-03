using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU_C968_1_v001
{
    public class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static BindingList<Part> Parts = new BindingList<Part>();

        static Part()
        {
            Parts.Add(
                new Part
                {
                    PartID = 1,
                    Name = "Hammer",
                    Price = 12.99,
                    InStock = 3,
                    Min = 0,
                    Max = 100
                }
            );

            Parts.Add(
                new Part
                {
                    PartID = 2,
                    Name = "Saw",
                    Price = 13.99,
                    InStock = 4,
                    Min = 0,
                    Max = 10
                }
            );

            Parts.Add(
                new Part
                {
                    PartID = 3,
                    Name = "Pliers",
                    Price = 7.99,
                    InStock = 25,
                    Min = 0,
                    Max = 150
                }
            );

            Parts.Add(
                new Part
                {
                    PartID = 4,
                    Name = "Wrench",
                    Price = 14.99,
                    InStock = 15,
                    Min = 0,
                    Max = 50
                }
            );

            Parts.Add(
                new Part
                {
                    PartID = 5,
                    Name = "Tape Measure",
                    Price = 8.99,
                    InStock = 40,
                    Min = 0,
                    Max = 100
                }
            );
        }
    }
}
