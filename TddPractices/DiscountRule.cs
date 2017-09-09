﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddPractices
{
    public class DiscountRule
    {
        public MemberLevel Level { get; set; }

        public double PriceGate { get; set; }

        public int QtyGate { get; set; }

        public double DiscountRate { get; set; }

        public bool IsDefault { get; set; }

        public bool IsMatchRule(MemberLevel level, double price, int qty)
        {
            return (level == this.Level &&
                price > this.PriceGate &&
                qty > this.QtyGate) ||
                this.IsDefault;
        }
    }
}
