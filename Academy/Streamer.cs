using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Academy
{
	// Single responsebility principle
	class Streamer
	{
		public Streamer()
		{

		}
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}
		internal static string SetDirectory()
		{
			string locatoin = System.Reflection.Assembly.GetEntryAssembly().Location;
			string path = System.IO.Path.GetDirectoryName(locatoin);
			Console.WriteLine(locatoin);
			Console.WriteLine(path);
			Directory.SetCurrentDirectory($"{path}\\..\\..");
			Console.WriteLine(Directory.GetCurrentDirectory());
			return Directory.GetCurrentDirectory();

		}
		internal static void Save(Human[] group, string filename)
		{
			SetDirectory();
			StreamWriter sw = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine(group[i].ToFileString());
			}
			sw.Close();
			Process.Start("excel", filename);
		}
		internal static Human[] Load(string filename)
		{
			SetDirectory();
			StreamReader sr = new StreamReader(filename);
			List<Human> group = new List<Human>();
			try
			{
				while(!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					string[] parts = buffer.Split(';');
					parts = parts.Where(i => i != "").ToArray();

					if (parts.Length == 1) continue;
					Console.WriteLine(buffer);
					//Human human = HumanFactory.Create(parts[0]);
					//human.Init(parts);
					//group.Add(human);
					group.Add(HumanFactory.Create(parts[0]).Init(parts));
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return group.ToArray();
		}
			
		
	}
}
