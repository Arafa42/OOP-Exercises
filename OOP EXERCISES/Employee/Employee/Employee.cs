using System;

namespace Employee
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private decimal monthlySalary;

        public decimal MonthlySalary
        {
            get { return monthlySalary; }
            set
            {
                if (value < 0) { monthlySalary = 0; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"INVALID SALARY FOR {this.FirstName}"); Console.ResetColor(); }
                else { monthlySalary = value; }
            }
        }

        public Employee(string FirstName, string LastName, decimal MonthlySalary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MonthlySalary = MonthlySalary;
        }

        public void DisplayData()
        {
            Console.WriteLine($"FIRSTNAME : {this.FirstName}");
            Console.WriteLine($"LASTNAME : {this.LastName}");
            Console.WriteLine($"MONTHLY SALARY : {this.MonthlySalary}");
            Console.WriteLine("");
        }


        public void RaiseSalary(int percentage)
        {
            decimal newSalary = 0.0m;
            newSalary = ((this.MonthlySalary / 100) * percentage) + MonthlySalary;
            Console.WriteLine($"RAISED SALARY OF {this.FirstName} WITH {percentage}%  : ({Math.Round(newSalary, 2)})");
        }


    }
}
