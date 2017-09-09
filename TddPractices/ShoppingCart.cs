using System;
using System.Collections.Generic;
using System.Linq;

namespace TddPractices
{
    public class ShoppingCart
    {
        private IEnumerable<DiscountRule> discountRules = new[]
        {
            new DiscountRule{ Level = "VIP", PriceGate = 500, QtyGate = 0, DiscountRate = 0.8, IsDefault = false },
            new DiscountRule{ Level = "NORMAL", PriceGate = 1000, QtyGate = 3, DiscountRate = 0.85, IsDefault = false },
            new DiscountRule{ DiscountRate = 1, IsDefault = true},
        };

        public double Calculate(string level, double price, int qty)
        {
            var totalPrice = price * qty;
            var discountRate = this.GetDiscountRate(level, qty, totalPrice);

            return totalPrice * discountRate;
        }

        private double GetDiscountRate(string level, int qty, double totalPrice)
        {
            var matchedRule = this.discountRules.Where(i => i.IsMatchRule(level, totalPrice, qty))
                                                .FirstOrDefault();

            return matchedRule.DiscountRate;
        }
    }
}