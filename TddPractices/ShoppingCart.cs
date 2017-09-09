﻿using System;

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
            var discountRate = 1d;
            if(level == "VIP" && totalPrice > 500)
            {
                discountRate = 0.8;
            }
            else if (totalPrice > 1000 && qty > 3)
            {
                discountRate = 0.85;
            }

            return totalPrice * discountRate;
        }
    }
}