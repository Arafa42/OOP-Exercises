using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTeacher
{
    class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("I'm going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }

    }
}
