using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTeacher
{
    class StudentAndTeacherTest
    {

        static void Main()
        {

            Person persoon1 = new Person();
            persoon1.Greet();
            Student student1 = new Student(); 
            student1.SetAge(21);
            student1.ShowAge();
            Teacher teacher1 = new Teacher();
            teacher1.Greet();
            teacher1.Explain();




        }
        

    }
}
