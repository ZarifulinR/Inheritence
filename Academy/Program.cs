//#define HOME_WORK
//#define LOAD_CHEK
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
#if LOAD_CHEK
			Human[] group = new Human[]
			{
				new Student ("Pinkman", "Jessie", 23, "Chemistry", "WW_220", 95, 96),
				new Student("Korob", "Stan", 20, "Chemistry", "WW_220", 12, 11),
				new Student("Slavin", "Stepan", 21, "Chemistry", "WW_220", 50, 50),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Teacher("Semenov", "Vasya", 37, "Chemistry", 12),
				new Teacher("Feaktistov", "Eduard", 86, "Chemistry", 50),
				new Graduate("Ivanov", "Ivan", 22, "math", "WW_220", 95, 96,"math")
			};
			//Streamer.Print(group);
			 Streamer.Save(group, "File.CSV");  
#endif
#if HOME_WORK
			//group.ToList().ForEach(i => Console.WriteLine(i.ToString()));
			StreamWriter sw = new StreamWriter("File.txt");
			//Console.WriteLine(group.ToString());
			//group.ToList().ForEach(i => sw.WriteLine(i.ToString()));
			//for (int i = 0; i < group.Length; i++)
			//{
			//	sw.WriteLine(group[i]);
			//}
			foreach (Human i in group)
			{
				sw.WriteLine(i);
			}
			sw.Close();
			StreamReader sr = new StreamReader("File.txt");
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(buffer);
			}

			sr.Close();
			Process.Start("notepad", "File.txt"); 
#endif
			Human[] group = Streamer.Load("File.CSV");

			Streamer.Print(group);

		}


	}
}
