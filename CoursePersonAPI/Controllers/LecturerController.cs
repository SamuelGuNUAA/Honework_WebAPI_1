using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CoursePersonAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoursePersonAPI.Controllers
{
    [Route("api/lecturers")]
    public class LecturerController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult resultLecturer;
            var result = CoursePersonDataStore.Instance().GetAllLecturers();
            if (result == null)
            {
                resultLecturer = NotFound();
            }
            else
            {
                resultLecturer = Ok(result);
            }
            return resultLecturer;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult resultLecturer;
            var result = CoursePersonDataStore.Instance().GetLecturerByID(id);
            if (result == null)
            {
                resultLecturer = NotFound();
            }
            else
            {
                resultLecturer = Ok(result);
            }
            return resultLecturer;
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Lecturer value)
        {
            IActionResult resultLecturer;
            var result = CoursePersonDataStore.Instance().AddLecturer(value);
            if (result)
            {
                resultLecturer = Ok(result);
            }
            else
            {
                resultLecturer = NotFound();
            }
            return resultLecturer;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Lecturer value)
        {
            IActionResult resultLecturer;
            var result = CoursePersonDataStore.Instance().UpdateLecturer(id, value);
            if (result)
            {
                resultLecturer = Accepted(result);
            }
            else
            {
                resultLecturer = NotFound();
            }
            return resultLecturer;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult resultLecturer;
            var result = CoursePersonDataStore.Instance().DeleteLecturer(id);
            if (result)
            {
                resultLecturer = NoContent();
            }
            else
            {
                resultLecturer = NotFound();
            }
            return resultLecturer;
        }
    }
}
