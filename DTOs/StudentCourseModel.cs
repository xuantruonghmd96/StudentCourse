using StudentCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.DTOs
{
    public class StudentCourseModel
    {
        //public int CourseId { get; set; }
        //public string CourseName { get; set; }
        public int Donated { get; set; }

        public CourseModel Course { get; set; }

        public StudentCourseModel(StudentCourseMap studentCourseMap)
        {
            //this.CourseId = studentCourseMap.Course == null ? 0 : studentCourseMap.Course.Id;
            //this.CourseName = studentCourseMap.Course?.Name;
            this.Donated = studentCourseMap.Donated;
            this.Course = new CourseModel(studentCourseMap.Course);
        }
    }
}
