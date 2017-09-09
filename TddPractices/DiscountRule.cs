using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddPractices
{
    public class DiscountRule
    {
        public string Level { get; set; }

        public double PriceGate { get; set; }

        public int QtyGate { get; set; }

        public double DiscountRate { get; set; }

        public bool IsMatchRule(string level, double price, int qty)
        {
            return level == this.Level &&
                price > this.PriceGate &&
                qty > this.QtyGate;
        }
    }
}
