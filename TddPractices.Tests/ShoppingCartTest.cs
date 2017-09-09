using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TddPractices.Tests
{
    public class ShoppingCartTest
    {
        // 1. VIP 會員, 購買 150 元商品 3 件, 結帳金額為 450 元
        // 2. VIP 會員, 購買 150 元商品 5 件, 結帳金額為 600 元
        // 3. 一般 會員, 購買 300 元商品 2 件, 結帳金額為 600 元
        // 4. 一般 會員, 購買 600 元商品 4 件, 結帳金額為 2040 元
        // 5. 一般 會員, 購買 600 元商品 2 件, 結帳金額為 1200 元
        // 6. 一般 會員, 購買 200 元商品 4 件, 結帳金額為 800 元
        [Theory]
        [InlineData("VIP", 150, 3, 450)]
        [InlineData("VIP", 150, 5, 600)]
        [InlineData("NORMAL", 300, 2, 600)]
        [InlineData("NORMAL", 600, 4, 2040)]
        public void Test_ShoppingCart_Calculate(string level, double price, int qty, double expected)
        {
            // Arrange
            var actual = 0d;
            var shoppingCart = new ShoppingCart();

            // Act
            actual = shoppingCart.Calculate(level, price, qty);

            // Arrange
            Assert.Equal(expected, actual);
        }
    }
}
