using System;
using System.Collections.Generic;
using System.Linq;

namespace TddPractices
{
    public class ShoppingCart
    {
        private IEnumerable<DiscountRule> discountRules = new[]
        {
            new DiscountRule{ Level = "VIP", PriceGate = 500, QtyGate = 0, DiscountRate = 0.8},
            new DiscountRule{ Level = "NORMAL", PriceGate = 1000, QtyGate = 3, DiscountRate = 0.85},
        };

        public double Calculate(string level, double price, int qty)
        {
            var totalPrice = price * qty;
            var discountRate = this.GetDiscountRate(level, qty, totalPrice);

            return totalPrice * discountRate;
        }

        private double GetDiscountRate(string level, int qty, double totalPrice)
        {
            var discountRate = 1d;
            var matchedRule = this.discountRules.Where(i => i.IsMatchRule(level, totalPrice, qty))
                                                .FirstOrDefault();
            if(matchedRule != null)
            {
                discountRate = matchedRule.DiscountRate;
            }

            return discountRate;
        }
    }
}