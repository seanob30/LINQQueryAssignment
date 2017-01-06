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
            char[] dummy = input.ToArray();
            Array.Sort(dummy);
            string temporaryString = new string(dummy);
            var wordCount = temporaryString.GroupBy(x => x).Select(x => new { Character = x.Key, Count = x.Count() });
            foreach (var item in wordCount) Console.WriteLine("Alphabet :" + item.Character + ", Count :" + item.Count);
        }
    }
}
