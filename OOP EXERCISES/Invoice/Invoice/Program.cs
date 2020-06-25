using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {



            Invoice obj = new Invoice("23KXZO23","kaka part",10,100);
            Console.WriteLine(obj.GetInvoideAmount());
            obj.Quantity = -5;
            obj.Price = 19;
            Console.WriteLine(obj.GetInvoideAmount());






        }
    }
}
