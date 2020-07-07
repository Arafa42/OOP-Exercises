using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTeacher
{
    class Person
    {

        protected int age=0;


        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int n)
        {
            age = n;
        }



    }
}
