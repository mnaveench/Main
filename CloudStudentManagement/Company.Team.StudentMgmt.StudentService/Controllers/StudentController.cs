using Company.Team.StudentMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Team.StudentMgmt.StudentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Student
            {
                Id = index,
                Name = "Student" + index
            })
            .ToArray();
        }

        [HttpGet] 
        [Route("Students")]
        public IEnumerable<Student> GetByNumber(int id)
        {
            var random = new Random();
            return Enumerable.Range(1, id).Select(index => new Student
            {
                Id = index,
                Name = "Student:" + index
            }).ToArray();
        }
    }
}
