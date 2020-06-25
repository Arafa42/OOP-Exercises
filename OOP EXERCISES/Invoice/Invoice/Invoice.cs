using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice
    {

        string partNr;
        string partDes;

        public int quantity;
        public int Quantity
        {
            get { return quantity; }
            set {                
                if (value > 0) { quantity = value; }
                else { Console.WriteLine("VALUE MUST BE ABOVE 0"); quantity = 0; } 
            }
        }


        public decimal price;
        public decimal Price
        {
            get { return price; }
            set { 
                if (value > 0) { price = value; }
                else { Console.WriteLine("PRICE MUST BE HIGHER THAN 0"); price = 0.0m; }
            }
        }


        public Invoice(string partNr, string partDes, int quantity, decimal price) 
        {
            this.partNr = partNr;
            this.partDes = partDes;
            this.Quantity = quantity;
            this.Price = price;
        }

        decimal totl;

        public decimal GetInvoideAmount()
        {
           

            totl = Quantity * Price;
            return totl;
        }





    }
}
