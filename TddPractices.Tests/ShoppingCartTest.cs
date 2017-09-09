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
        [Fact]
        public void Test_ShoppingCart_Calculate()
        {
            // Arrange
            var level = "VIP";
            var price = 150d;
            var qty = 3;
            var expected = 450d;
            var actual = 0d;
            var shoppingCart = new ShoppingCart();

            // Act
            actual = shoppingCart.Calculate(level, price, qty);

            // Arrange
            Assert.Equal(expected, actual);
        }
    }
}
