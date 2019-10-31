using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.Models
{
    public class StudentCourseMap
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Donated { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
