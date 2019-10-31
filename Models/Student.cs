using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentCourseMap> StudentCourseMaps { get; set; }
    }
}
