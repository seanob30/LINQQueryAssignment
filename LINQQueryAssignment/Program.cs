using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> grades = new List<string>() { "90,80,70,95,85,75", "100,90,95,85,75,65", "90,90,90,85,75,60" };
            CharacterFrequency test = new CharacterFrequency();
            string check = "warneverchanges";
            test.Order(check);
            Console.ReadKey();
        }
    }
}
