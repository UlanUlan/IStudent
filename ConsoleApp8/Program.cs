using ConsoleApp8.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ab", "Abraham");
            string name = s.GetName(), fullName = s.GetFullName();
            double avgGrade = s.GetAvgGrade();
            Console.WriteLine("Name: {0}. Full name: {1}. Average grade: {2}.", name, fullName, avgGrade);
            Console.WriteLine("----------------------------------------------------");
            s.showGrades();
        }
    }
}
