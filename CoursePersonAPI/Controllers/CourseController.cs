using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CoursePersonAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoursePersonAPI.Controllers
{
    [Route("api/courses")]
    public class CourseController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult courseResult;
            var result = CoursePersonDataStore.Instance().GetAllCourses();
            if(result == null)
            {
                courseResult = NotFound();
            }
            else
            {
                courseResult = Ok(result);
            }
            return courseResult;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult courseResult;
            var result = CoursePersonDataStore.Instance().GetCourseByID(id);
            if(result == null)
            {
                courseResult = NotFound();
            }
            else
            {
                courseResult = Ok(result);
            }
            return courseResult;
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Course value)
        {
            IActionResult addResult;
            var result = CoursePersonDataStore.Instance().AddCourse(value);
            if (result)
            {
                addResult = Ok(result);
            }
            else
            {
                addResult = NotFound();
            }
            return addResult;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Course value)
        {
            IActionResult updateResult;
            var result = CoursePersonDataStore.Instance().UpdateCourse(id, value);
            if (result)
            {
                updateResult = Accepted(result);
            }
            else
            {
                updateResult = NotFound();
            }
            return updateResult;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult deleteResult;
            var result = CoursePersonDataStore.Instance().DeleteCourse(id);
            if (result)
            {
                deleteResult = NoContent();
            }
            else
            {
                deleteResult = NotFound();
            }
            return deleteResult;
        }
    }
}
