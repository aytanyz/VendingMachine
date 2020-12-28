using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public static class DB
    {

        public static int len = 4;
        public static Drink[] drinkList = new Drink[len];
        public static int len_discount = 3;
        public static Discount[] discountList = new Discount[len_discount];

        public static void create()
        {
            DB.drinkList[0] = new Drink("Italian Coffee", 2.5, "icon1");
            DB.drinkList[1] = new Drink("American Coffee", 2, "icon2");
            DB.drinkList[2] = new Drink("Tea", 1.5, "icon3");
            DB.drinkList[3] = new Drink("Chocolate", 2.4, "icon4");

            DB.discountList[0] = new Discount("promo15", 15);
            DB.discountList[1] = new Discount("promo20", 20);
            DB.discountList[2] = new Discount("promo50", 50);
        }
    }

   
}
