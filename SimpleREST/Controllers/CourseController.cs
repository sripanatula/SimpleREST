using SimpleREST.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SimpleREST.Controllers
{
    public class CourseController : ApiController
    {

        Course[] courses = new Course[]{
            new Course{Id=1, Name="Vardhani School of Music", Description="Carnatic Classical Music", Skills="vocal carnatic classical indian music"},
            new Course{Id=2, Name="Aaradhya Dance Academy", Description="Kuchipudi Classical Dance", Skills="Kuchipudi dance classical indian "},
            new Course{Id=3, Name="Sangeetha School of Dance", Description="Bharatantyam Classical Dance", Skills="classical indian dance bharatanatyam"}
        };
        
        
        // GET api/<controller>
        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            Course course = courses.FirstOrDefault((c) => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}