using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Montana", "Antonia", 25);
            human.Print();
            Console.WriteLine(human);
            Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
            Console.WriteLine(student);
            student.Print();
            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher);
            teacher.Print();
        }
        
    }
}
