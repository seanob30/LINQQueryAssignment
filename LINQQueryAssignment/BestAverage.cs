using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueryAssignment
{
    class BestAverage
    {
        public double TotalGradesAverage(List<string> grades)
        {
            int studentNumber = grades.Count;
            string joined = string.Join<string>(",", grades);
            string [] soloGrades = joined.Split(',');
            var tempArray = Array.ConvertAll(soloGrades, int.Parse);
            var result = tempArray.OrderByDescending(x => x).ToList();
            for(int i=0; i < studentNumber; i++)
            {
                result.Reverse();
                result.RemoveAt(0);
                result.Reverse();
            }
            double classAverage = result.Average();
            return classAverage;
        }
    }
}
