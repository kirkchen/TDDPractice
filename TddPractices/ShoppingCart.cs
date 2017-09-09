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
            if(level == "VIP" && totalPrice > 500)
            {
                return totalPrice * 0.8;
            }
            else if (totalPrice > 1000 && qty > 3)
            {
                return totalPrice * 0.85;
            }

            return totalPrice;
        }
    }
}