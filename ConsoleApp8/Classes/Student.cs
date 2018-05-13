using ConsoleApp8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Classes
{
    public class Student : IStudent
    {
        private Random rand = new Random();
        public Student(string _Name, string _FullName)
        {
            Name = _Name;
            FullName = _FullName;
            Grades = new int[rand.Next(2, 10)];
            for (int i = 0; i < Grades.Length; i++)
            {
                Grades[i] = rand.Next(1, 10);
            }
        }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public double GetAvgGrade()
        {
            int a = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                a += Grades[i];
            }
            return (double)a / (double)Grades.Length;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
        public void showGrades()
        {
            Console.Write("Grades: ");
            for (int i = 0; i < Grades.Length; i++)
            {
                Console.Write(Grades[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
