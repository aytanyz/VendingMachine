# VendingMachine
This project developed using C# .Net. It is a simple UI project that gives the possibility to choose drinks and amount, apply discount code, and pay. Additionally, the project contains some unit tests.

## Description
There are 4 types of drinks. 
* Italian Coffee
* American Coffee
* Tea
* Chocolate

User can choose one or more drinks and go to the Basket. If the user wants to add/remove drinks he/she can return back by clicking the "Back" button. Note that if no drink is chosen user cannot click on the "Next" button. After clicking the "Next" button user will be redirected to the Basket. Here he/she can modify the quantity of each selected drink and pay. User can also apply discount codes which are in the following:
* "promo15" gives 15% discount
* "promo20" gives 20% discount
* "promo50" gives 50% discount

If the total cost is greater than 10 euro user forced to pay with a card. Otherwise, there are 2 payment possibilities: "Pay card" and "Pay cash". After successful payment user can leave the application or go back to the HomePage and reorder again.  
