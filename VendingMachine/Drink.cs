using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Drink
    {
        public string name;
        public bool isSelected = false;
        public double price;
        public string iconName;
        
        public Drink() { }

        public Drink (string name, double price, string iconName) {
            this.name = name;
            this.price = price;
            this.iconName = iconName;
        }        
    }
}
