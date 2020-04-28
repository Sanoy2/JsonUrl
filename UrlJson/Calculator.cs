using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlJson.Models;

namespace UrlJson
{
    public class Calculator
    {
        public Result Calculate(Grades grades)
        {
            Result result = new Result()
            {
                StudentName = grades.StudentName,
                GradesCount = grades.StudentGrades.Count(),
                GradesMean = this.CalculateMean(grades.StudentGrades)
            };

            return result;
        }

        private decimal CalculateMean(IEnumerable<decimal> grades)
        {
            int count = grades.Count();
            decimal sum = grades.Sum();

            return sum / count;
        }
    }
}
