namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emply1 = new Employee("John", "Doe", -1934.39m);
            Employee emply2 = new Employee("Kelly", "Hoe", 3934.39m);

            emply1.DisplayData();
            emply2.DisplayData();

            //RAISE IN PERCENT
            emply1.RaiseSalary(10);

        }
    }
}
