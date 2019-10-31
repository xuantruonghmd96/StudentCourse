using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentCourseMap> StudentCourseMaps { get; set; }
    }
}
