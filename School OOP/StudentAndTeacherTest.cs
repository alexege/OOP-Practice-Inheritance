using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise Source: https://practiceexercisecsharp.blogspot.com/2017/05/exercise-c-sharp-601-classes-student-and-teacher.html

namespace School_OOP
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Greet();

            Student student1 = new Student();
            student1.SetAge(21);
            student1.Greet();
            student1.ShowAge();

            Teacher teacher1 = new Teacher();
            teacher1.SetAge(30);
            teacher1.Greet();
            teacher1.Explain();
        }
    }
}
