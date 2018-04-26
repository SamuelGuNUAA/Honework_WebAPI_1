using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CoursePersonAPI.Model;

namespace CoursePersonAPI.Controllers
{
    [Route("api/students")]
    public class StudentController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult studentResult;
            var result = CoursePersonDataStore.Instance().GetAllStudents();
            if(result == null)
            {
                studentResult = NotFound();
            }
            else
            {
                studentResult = Ok(result);
            }
            return studentResult;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult studentResult;
            var result = CoursePersonDataStore.Instance().GetStudentByID(id);
            if (result == null)
            {
                studentResult = NotFound();
            }
            else
            {
                studentResult = Ok(result);
            }
            return studentResult;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Student value)
        {
            IActionResult studentResult;
            var result = CoursePersonDataStore.Instance().addStudent(value);
            if (result)
            {
                studentResult = Ok(result);
            }
            else
            {
                studentResult = NotFound();
            }
            return studentResult;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Student value)
        {
            IActionResult studentResult;
            var result = CoursePersonDataStore.Instance().updateStudent(id, value);
            if (result)
            {
                studentResult = Accepted(result);
            }
            else
            {
                studentResult = NotFound();
            }
            return studentResult;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult studentResult;
            var result = CoursePersonDataStore.Instance().deleteStudent(id);
            if (result)
            {
                studentResult = NoContent();
            }
            else
            {
                studentResult = NotFound();
            }
            return studentResult;
        }
    }
}
