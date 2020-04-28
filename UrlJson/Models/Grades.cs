using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlJson.Models
{
    public class Grades
    {
        public string StudentName { get; set; }
        public List<decimal> StudentGrades { get; set; }
    }
}
