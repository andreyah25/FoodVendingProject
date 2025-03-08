using System;

namespace FoodVendingMachine
{
    class FoodVending
    {
        static void Main(string[] args)
        {
            double cardBalance = 200.00;
            int pin = 2254;
            Console.WriteLine("Insert your card.");
            Console.WriteLine("Enter a PIN: ");
            int userPIN = Convert.ToInt16(Console.ReadLine());

            if (userPIN == pin)
            {
                Console.WriteLine("Snacks or Drinks: ");
                string[] foods = new string[] { "[1]Piattos- $1.29", "[2]VCut - $2.07", "[3]Cheesy - $1.78", "[4]Pic A - $3.45", "[5]Royal - $2.99", "[6]Mountain Dew -$ 2.56", "[7]CANCEL" };
                double[] prices = new double[] { 1.29, 2.07, 1.78, 3.45, 2.99, 2.56 };

                foreach (string food in foods)
                {
                    Console.WriteLine(food);
                }
                Console.WriteLine("Pick your choice: ");
                int userFoodChoice = Convert.ToInt16(Console.ReadLine());

                if (userFoodChoice >= 1 && userFoodChoice <= 6)
                {
                    double itemPrice = prices[userFoodChoice - 1];
                    string itemName = foods[userFoodChoice - 1].Split('-')[0];

                    if (cardBalance >= itemPrice)
                    {
                        cardBalance -= itemPrice;
                        Console.WriteLine($"You selected {itemName} \n Price: {itemPrice}");
                        Console.WriteLine($"Current Balance: {cardBalance}");
                        Console.WriteLine($"Remaining Balance is {cardBalance}");

                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds.");

                    }
                }
                else if (userFoodChoice == 7)
                {
                    Console.WriteLine("Cancelled.");

                }
                else
                {
                    Console.WriteLine("Not Available, Try Again.");
                }
            }
            else
            {
                Console.WriteLine("Access Denied. Incorrect PIN");
            }

        }
    }
}