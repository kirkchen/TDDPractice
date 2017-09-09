using System;

namespace TddPractices
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public double Calculate(string level, double price, int qty)
        {
            var totalPrice = price * qty;
            double discountRate = this.GetDiscountRate(level, qty, totalPrice);

            return totalPrice * discountRate;
        }

        private double GetDiscountRate(string level, int qty, double totalPrice)
        {
            var discountRate = 1d;
            if (level == "VIP" && totalPrice > 500 && qty > 0)
            {
                discountRate = 0.8;
            }
            else if (level == "NORMAL" && totalPrice > 1000 && qty > 3)
            {
                discountRate = 0.85;
            }

            return discountRate;
        }
    }
}