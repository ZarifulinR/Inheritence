using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human("Montana", "Antonia", 25);
            //human.Print();
            //Console.WriteLine(human);
            //Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
            //Console.WriteLine(student);
            //student.Print();
            //Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            //Console.WriteLine(teacher);
            //teacher.Print();
            //Graduate graduate = new Graduate("ivanov", "ivan", 22, "math", "WW_220", 95, 96,"math");
            //Console.WriteLine(graduate);
            //graduate.Print();
            Human[] group = new Human[]
            {
                new Student ("Pinkman", "Jessie", 23, "Chemistry", "WW_220", 95, 96),
                new Student("Korob", "Stan", 20, "Chemistry", "WW_220", 12, 11),
                new Student("Slavin", "Stepan", 21, "Chemistry", "WW_220", 50, 50),
                new Teacher("White", "Walter", 50, "Chemistry", 25),
                new Teacher("Semenov", "Vasya", 37, "Chemistry", 12),
                new Teacher("Feaktistov", "Eduard", 86, "Chemistry", 50),
                new Graduate("ivanov", "ivan", 22, "math", "WW_220", 95, 96,"math")

            };
            group.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            StreamWriter sw = new StreamWriter("File.txt");
            foreach (var item in group.ToString())
            {
                sw.WriteLine(group);
            }
            
           
        }
        
    }
}
