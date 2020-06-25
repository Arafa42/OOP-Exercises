using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine1 = new VendingMachine();
            Console.WriteLine("WELCOME TO VENDINGMACHINE ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("INSERT COINS TO BUY A DRINK...");
            double insertedCoins = Convert.ToDouble(Console.ReadLine());
            machine1.DepositCount(insertedCoins);
            Console.WriteLine("PRESS 1 TO BUY DRINK (0.75)");
            Console.WriteLine($"PRESS 2 TO REFUND CURRENT AMOUNT : {insertedCoins}");
            string pressed = Console.ReadLine();
            if (pressed == "1")
            {
                machine1.GetDrink();
            }
            else if (pressed == "2")
            {
                machine1.GetRefund();
            }
            else
            {
                Console.WriteLine("NO VALID INPUT");
            }
        }
    }
}
