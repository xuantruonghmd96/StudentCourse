using StudentCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.DTOs
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public IEnumerable<StudentModel> Students { get; set; }

        public CourseModel(Course course)
        {
            if (course == null)
                return;
            this.Id = course.Id;
            this.Name = course.Name;
            //this.Students = course.StudentCourseMaps.Select(x => new StudentModel(x.Student));
        }
    }
}
