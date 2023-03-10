using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU_C968_1_v001
{
    public class OutsourcedPart : Part
    {
        public string CompName { get; set; }

        public OutsourcedPart() { }

        public OutsourcedPart(int ID, string name, double price, int stock, int max, int min)
        {
            PartID = ID;
            Name = name;
            InStock = stock;
            Price = price;
            Max = max;
            Min = min;
        }

        public OutsourcedPart(
            int ID,
            string name,
            double price,
            int stock,
            int max,
            int min,
            string compName
        )
        {
            PartID = ID;
            Name = name;
            InStock = stock;
            Price = price;
            Max = max;
            Min = min;
            CompName = compName;
        }
    }
}
