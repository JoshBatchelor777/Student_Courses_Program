using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourses_Challenge
{
    public class Enrollment
    {
        public Course Course { get; set; }
        public Student Student { get; set; }
        public double Grade { get; set; }
    }
}
