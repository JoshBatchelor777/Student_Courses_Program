﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourses_Challenge
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
