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
            string [] soloGrades = string.Join<string>(",", grades).Split(',');
            var result = Array.ConvertAll(soloGrades, int.Parse).OrderByDescending(x => x).ToList();
            for(int i = 0; i < studentNumber; i++)
            {
                result.Remove(result.Min());
            }
            double classAverage = result.Average();
            return classAverage;
        }
    }
}
