using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VendingMachine.Test
{
    [TestClass()]
    public class BasketTest
    {
        
        [TestMethod()]
        public void INPUT_totalCost_choosenDrink_Test()
        {
            int idx;
            Decimal drink_amount;


            // test 1
            idx = 1;
            drink_amount = 2;
            totalCost_choosenDrink_Test(drink_amount, idx);

            // test 2
            idx = 2;
            drink_amount = 10;
            totalCost_choosenDrink_Test(drink_amount, idx);


            // test 2
            idx = 3;
            drink_amount = 100;
            totalCost_choosenDrink_Test(drink_amount, idx);
        }

        public void totalCost_choosenDrink_Test(Decimal drink_amount, int idx)
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            double drink_price = DB.drinkList[idx].price;
            double expected = Math.Round((Decimal.ToInt32(drink_amount) * drink_price), 2);

            // Act
            double actual = basket.totalCost_choosenDrink(drink_amount, idx);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void getSubtota_Test()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            DB.drinkList[1].isSelected = true;
            DB.drinkList[3].isSelected = true;
            basket.amount[1] = 3;
            basket.amount[3] = 4;
            double expected = Math.Round((3 * DB.drinkList[1].price + 4 * DB.drinkList[3].price),2);

            // Act           
            double actual = basket.getSubtotal();

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void getTotal_NoDiscountApplied()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            DB.drinkList[1].isSelected = true;
            DB.drinkList[3].isSelected = true;
            basket.amount[1] = 3;
            basket.amount[3] = 4;
            basket.discount = 0;
            double subtotal = Math.Round((basket.amount[1] * DB.drinkList[1].price + basket.amount[3] * DB.drinkList[3].price), 2);
            double expected = subtotal;

            // Act           
            double actual = basket.getTotal(subtotal);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void getTotal_DiscountApplied()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            DB.drinkList[0].isSelected = true;
            DB.drinkList[3].isSelected = true;
            int percentage = DB.discountList[2].discount_percentage;
            basket.amount[0] = 6;
            basket.amount[3] = 1;
            basket.discount = percentage;
            double subtotal = Math.Round((basket.amount[0] * DB.drinkList[0].price + basket.amount[3] * DB.drinkList[3].price), 2);
            double expected = Math.Round((subtotal*(100-percentage)/100),2);

            // Act           
            double actual = basket.getTotal(subtotal);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void getDiscountAmount_NoDiscountApplied()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            DB.drinkList[0].isSelected = true;
            DB.drinkList[3].isSelected = true;
            basket.amount[0] = 6;
            basket.amount[3] = 1;
            basket.discount = 0;
            double subtotal = Math.Round((basket.amount[0] * DB.drinkList[0].price + basket.amount[3] * DB.drinkList[3].price), 2);
            string expected = "";

            // Act           
            string actual = basket.getDiscountAmount(subtotal);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void getDiscountAmount_DiscountApplied()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            DB.drinkList[0].isSelected = true;
            DB.drinkList[3].isSelected = true;
            int percentage = DB.discountList[0].discount_percentage;
            basket.amount[0] = 6;
            basket.amount[3] = 1;
            basket.discount = percentage;
            double subtotal = Math.Round((basket.amount[0] * DB.drinkList[0].price + basket.amount[3] * DB.drinkList[3].price), 2);
            string expected = "-" + Math.Round((subtotal * percentage / 100), 2).ToString() + " euro";

            // Act           
            string actual = basket.getDiscountAmount(subtotal);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void toggle_PayCash_isLessThan10()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            double total = 9.80;
            bool expected = true;

            // Act  
            basket.toggle_PayCash(total);
            bool actual = basket.Controls["payCash_button"].Enabled;

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void toggle_PayCash_is10()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            double total = 10;
            bool expected = true;

            // Act  
            basket.toggle_PayCash(total);
            bool actual = basket.Controls["payCash_button"].Enabled;

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void toggle_PayCash_isGreaterThan10()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            double total = 10.20;
            bool expected = false;

            // Act  
            basket.toggle_PayCash(total);
            bool actual = basket.Controls["payCash_button"].Enabled;

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void check_discountCode_ifExists()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            string code = DB.discountList[2].discount_code;
            int discount_percentage = DB.discountList[2].discount_percentage;
            basket.Controls["discount_code"].Text = code;            
            bool expected = true;
            int expected_percentage = discount_percentage;

            // Act              
            bool actual = basket.check_discountCode();
            int actual_percentage = basket.discount;

            // Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual_percentage, expected_percentage);
        }

        [TestMethod()]
        public void check_discountCode_NotExist()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            string code = "promo60";
            basket.Controls["discount_code"].Text = code;
            bool expected = false;
            int expected_percentage = 0;

            // Act              
            bool actual = basket.check_discountCode();
            int actual_percentage = basket.discount;

            // Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actual_percentage, expected_percentage);
        }

        [TestMethod()]
        public void resetAll_Test()
        {
            // Arrange
            DB.create();
            Basket basket = new Basket();

            DB.drinkList[2].isSelected = true;
            DB.drinkList[3].isSelected = true;
            bool expexted = false;

            // Act              
            basket.resetAll();

            // Assert
            Assert.AreEqual(DB.drinkList[2].isSelected, expexted);
            Assert.AreEqual(DB.drinkList[3].isSelected, expexted);
        }
    }
}
