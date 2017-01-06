using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueryAssignment
{
    class DuplicateRemoval
    {
        public List<string> Clone(List<string> original)
        {
            List<string> copy = original.Distinct().ToList();
            return copy;
        }
    }
}
