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
            string[] soloGrades = string.Join<string>(",", grades).Split(',');
            var result = Array.ConvertAll(soloGrades, int.Parse).OrderByDescending(x => x).ToList();
            foreach (var element in grades)
            {
                result.Remove(result.Min());
            }
            double classAverage = result.Average();
            return classAverage;


        }
            ////experimentation*****
            //var temporaryString = string.Join<string>(",", grades);
            //var result = from c in temporaryString
            //             group c by c;
            //foreach (var item in grades)
            //{
            //    result.Reverse().Skip(1).Reverse();
            //}
            //double classAverage = result.ToList().Average();
            //return classAverage;
        
    }
}
