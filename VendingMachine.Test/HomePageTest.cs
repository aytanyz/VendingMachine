using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Test
{
    [TestClass()]
    public class HomePageTest
    {
        [TestMethod()]
        public void change_color_panel_ifWasSelected()
        {
            // Arrange
            DB.create();
            HomePage hp = new HomePage();

            int idx = 0;
            string panel_name = "drinkPanel" + idx.ToString();
            string selected_box_name = "drinkSelectBox" + idx.ToString();
            DB.drinkList[idx].isSelected = true;
            System.Drawing.Color expected_paneld_color = System.Drawing.Color.Transparent;
            System.Drawing.Color expected_box_color = System.Drawing.Color.White;

            // Act
            hp.change_color_panel(idx, panel_name, selected_box_name);
            System.Drawing.Color actual_panel_color = hp.Controls[panel_name].BackColor;
            System.Drawing.Color actual_box_color = hp.Controls[panel_name].Controls[selected_box_name].BackColor;

            // Assert
            Assert.AreEqual(expected_paneld_color, actual_panel_color);
            Assert.AreEqual(expected_box_color, actual_box_color);
        }

        [TestMethod()]
        public void change_color_panel_ifWasNotSelected()
        {
            // Arrange
            DB.create();
            HomePage hp = new HomePage();

            int idx = 2;
            string panel_name = "drinkPanel" + idx.ToString();
            string selected_box_name = "drinkSelectBox" + idx.ToString();
            DB.drinkList[idx].isSelected = false;
            System.Drawing.Color expected_paneld_color = System.Drawing.Color.White;
            System.Drawing.Color expected_box_color = System.Drawing.Color.SkyBlue;

            // Act
            hp.change_color_panel(idx, panel_name, selected_box_name);
            System.Drawing.Color actual_panel_color = hp.Controls[panel_name].BackColor;
            System.Drawing.Color actual_box_color = hp.Controls[panel_name].Controls[selected_box_name].BackColor;

            // Assert
            Assert.AreEqual(expected_paneld_color, actual_panel_color);
            Assert.AreEqual(expected_box_color, actual_box_color);
        }

        [TestMethod()]
        public void change_value_isSelected_ifTrue()
        {
            // Arrange
            HomePage hp = new HomePage();
            DB.create();

            int idx = 0;
            DB.drinkList[idx].isSelected = true;
            bool expected = false;
            hp.change_value_isSelected(idx);

            // Act
            bool actual = DB.drinkList[idx].isSelected;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void change_value_isSelected_ifFalse()
        {
            // Arrange
            HomePage hp = new HomePage();
            DB.create();

            int idx = 0;
            DB.drinkList[idx].isSelected = false;
            bool expected = true;
            hp.change_value_isSelected(idx);

            // Act
            bool actual = DB.drinkList[idx].isSelected;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void toggleButton_Next_ifOneDrinkWasSelected()
        {
            // Arrange
            HomePage hp = new HomePage();
            DB.create();

            int idx = 0;
            DB.drinkList[idx].isSelected = true;
            bool expected_next_button_enabled = true;
            System.Drawing.Color expected_next_button_color = System.Drawing.Color.White;
            hp.toggleButton_Next();

            // Act
            bool actual_next_button_enabled = hp.Controls["next_button"].Enabled;
            System.Drawing.Color actual_next_button_color = hp.Controls["next_button"].BackColor;

            // Assert
            Assert.AreEqual(expected_next_button_enabled, actual_next_button_enabled);
            Assert.AreEqual(expected_next_button_color, actual_next_button_color);
        }

        [TestMethod()]
        public void toggleButton_Next_ifTwoDrinksWereSelected()
        {
            // Arrange
            HomePage hp = new HomePage();
            DB.create();

            int idx1 = 0, idx2 = 3;

            DB.drinkList[idx1].isSelected = DB.drinkList[idx2].isSelected = true;
            bool expected_next_button_enabled = true;
            System.Drawing.Color expected_next_button_color = System.Drawing.Color.White;
            hp.toggleButton_Next();

            // Act
            bool actual_next_button_enabled = hp.Controls["next_button"].Enabled;
            System.Drawing.Color actual_next_button_color = hp.Controls["next_button"].BackColor;

            // Assert
            Assert.AreEqual(expected_next_button_enabled, actual_next_button_enabled);
            Assert.AreEqual(expected_next_button_color, actual_next_button_color);
        }

        [TestMethod()]
        public void toggleButton_Next_ifNoDrinkWasSelected()
        {
            // Arrange
            HomePage hp = new HomePage();
            DB.create();

            bool expected_next_button_enabled = false;
            System.Drawing.Color expected_next_button_color = System.Drawing.Color.Transparent;
            hp.toggleButton_Next();

            // Act
            bool actual_next_button_enabled = hp.Controls["next_button"].Enabled;
            System.Drawing.Color actual_next_button_color = hp.Controls["next_button"].BackColor;

            // Assert
            Assert.AreEqual(expected_next_button_enabled, actual_next_button_enabled);
            Assert.AreEqual(expected_next_button_color, actual_next_button_color);
        }
    }
}