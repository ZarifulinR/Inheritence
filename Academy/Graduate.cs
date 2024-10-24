﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Graduate:Student
    {
        public  string Subject { get; set; }
        public Graduate
        (string lastName, string firstName, int age,
        string speciality, string group, double rating, double attendance,
        string subject) : base(lastName, firstName, age, speciality, group, rating, attendance)
        {
            Subject = subject;
            Console.WriteLine($"GConstructor{GetHashCode()}");
        }

        ~Graduate()
        {
            Console.WriteLine($"GDestructor{GetHashCode()}");
                
        }
        public override void  Print()
        {
            base.Print();
            Console.WriteLine($" {Subject }");
        }
        public override string ToString()
        {
            string base_string = base.ToString();
            return base_string +$" {Subject}";
        }
		public override string ToFileString()
		{
			return base.ToFileString()+$";{Speciality}";
		}
        public override Human Init(string[] values)
        {
            base.Init(values);
            Subject    = values[8];
            return this;
        }
    }
    
}
