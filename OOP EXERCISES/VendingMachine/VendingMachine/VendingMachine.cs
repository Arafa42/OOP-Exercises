using System;

namespace VendingMachine
{
    class VendingMachine
    {
        public double DepositedAmount { get; set; }

        public VendingMachine()
        {
            DepositedAmount = 0.0;
        }

        public void DepositCount(double coinAmount)
        {
            DepositedAmount += coinAmount;
        }

        public void GetDrink()
        {
            if (DepositedAmount > 0.75)
            {
                //CALCULATE CHANGE
                double drinkPrice = 0.75;
                double change = DepositedAmount - drinkPrice;
                Console.WriteLine($"Your change is : {Math.Round(change, 2)}");
                DepositedAmount = 0;
            }
            else
            {
                while (DepositedAmount < 0.75)
                {
                    Console.WriteLine($"Insert more coins (current : {Math.Round(DepositedAmount, 2)} ) : ");
                    DepositedAmount += Convert.ToDouble(Console.ReadLine());
                }
                if (DepositedAmount >= 0.75)
                {
                    //CALCULATE CHANGE
                    double drinkPrice = 0.75;
                    double change = DepositedAmount - drinkPrice;
                    Console.WriteLine($"Your change is : {Math.Round(change, 2)}");
                    DepositedAmount = 0;
                }

            }
        }

        public void GetRefund()
        {
            if (DepositedAmount != 0.0)
            {
                Console.WriteLine($"You've been deposited : {DepositedAmount}");
                DepositedAmount = 0;
            }
            else
            {
                Console.WriteLine("NO COINS INSERTED");
            }
        }
    }
}
