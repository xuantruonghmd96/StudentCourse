using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.Models
{
    public class Student_2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
    }
}
