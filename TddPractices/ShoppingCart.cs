using System;
using System.Collections.Generic;

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
            double discountRate = this.GetDiscountRate(level, qty, totalPrice);

            return totalPrice * discountRate;
        }

        private double GetDiscountRate(string level, int qty, double totalPrice)
        {
            var discountRate = 1d;
            foreach (var rule in this.discountRules)
            {
                if(rule.IsMatchRule(level, totalPrice, qty))
                {
                    discountRate = rule.DiscountRate;
                    break;
                }
            }

            return discountRate;
        }
    }
}