using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VendingMachine.Test
{
    [TestClass()]
    public class OrderReadyTest
    {
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
