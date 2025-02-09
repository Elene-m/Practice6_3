using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6_3
{
    internal class StudentProfessorTest
    {
        public static void Test()
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(20);
            student.Greet();
            student.ShowAge();
            student.Study();

            Professor professor = new Professor();
            professor.SetAge(45);
            professor.Greet();
            professor.Explain();
        }
    }
}
