using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Discount
    {
        public string discount_code;
        public int discount_percentage;
        
        public Discount() { }

        public Discount(string discount_code, int discount_percentage)
        {
            this.discount_code = discount_code;
            this.discount_percentage = discount_percentage;
        }
    }
}
