using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCourse.DTOs;
using StudentCourse.Models;

namespace StudentCourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApiDbContext dbContext;

        public StudentsController(ApiDbContext dbContext)
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

            var res = dbContext.Students
                .Include(x => x.StudentCourseMaps).ThenInclude(x => x.Course)
                .Select(x => new StudentModel(x));

            //var res = dbContext.Students
            //    .Include(x => x.StudentCourseMaps).ThenInclude(x => x.Course);
            return Ok(res);
        }

        [HttpGet("lazy")]
        public IActionResult GetLazy()
        {
            var res = dbContext.Students
                .Select(x => new StudentModel(x));

            return Ok(res);
        }
    }
}