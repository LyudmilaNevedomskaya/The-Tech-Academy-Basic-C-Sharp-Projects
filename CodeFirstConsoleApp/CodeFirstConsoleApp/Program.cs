﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConsoleApp
{
    internal class Program
    {
        public static void Main()
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student saved successfully!");
                Console.ReadLine();
            }
            
        }
    }
}
