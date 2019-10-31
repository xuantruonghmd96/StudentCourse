using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCourse.Models;

namespace StudentCourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentGradeController : ControllerBase
    {
        private readonly ApiDbContext dbContext;

        public StudentGradeController(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //var res = dbContext.Students
            //    .Select(x => new
            //    {
            //        Name = x.Name,
            //        Id = x.Id,
            //        StudentCourse = x.StudentCourseMaps.Select(x => new
            //        {
            //            StudentId = x.StudentId,
            //            CourseId = x.CourseId,
            //            Course = x.Course
            //        })
            //    });

            var res = dbContext.Student_2s
                .Include(x => x.Grade).ThenInclude(x => x.Teacher);
            return Ok(res);
        }
    }
}