using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU_C968_1_v001
{
    class Quote
    {
        
        public static int qCount;

        public Quote(string n)
        {
            QuoteID = qCount++;
            QuoteTxt = n;
        }

        public int QuoteID { get; set; }
        public string QuoteTxt { get; set; }
    }
}

