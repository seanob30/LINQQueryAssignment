using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueryAssignment
{
    class CharacterFrequency
    {
        public void Order(string input)
        {
            var result = from c in input.ToLower()
                         group c by c;
            foreach (var item in result)
            {
                Console.WriteLine("Alphabet :" + item.Key + ", Count :" + item.Count());
            }
        }
    }
}
