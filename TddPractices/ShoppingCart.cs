using System;
using System.Collections.Generic;
using System.Linq;

namespace TddPractices
{
    public class ShoppingCart
    {
        private IEnumerable<DiscountRule> discountRules = new[]
        {
            new DiscountRule{ Level = MemberLevel.VIP, PriceGate = 500, QtyGate = 0, DiscountRate = 0.8, IsDefault = false },
            new DiscountRule{ Level = MemberLevel.Normal, PriceGate = 1000, QtyGate = 3, DiscountRate = 0.85, IsDefault = false },
            new DiscountRule{ DiscountRate = 1, IsDefault = true},
        };

        public double Calculate(MemberLevel level, double price, int qty)
        {
            var totalPrice = price * qty;
            var matchedRule = this.discountRules.FirstOrDefault(i => i.IsMatchRule(level, totalPrice, qty));

            return totalPrice * matchedRule.DiscountRate;
        }
    }
}