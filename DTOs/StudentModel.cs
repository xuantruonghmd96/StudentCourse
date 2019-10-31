using StudentCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.DTOs
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<CourseModel> Courses { get; set; }
        public IEnumerable<StudentCourseModel> StudentCourses { get; set; }

        public StudentModel(Student student)
        {
            this.Id = student.Id;
            this.Name = student.Name;
            this.Courses = student.StudentCourseMaps?.Select(x => new CourseModel(x.Course));
            this.StudentCourses = student.StudentCourseMaps?.Select(x => new StudentCourseModel(x));
        }
    }
}
