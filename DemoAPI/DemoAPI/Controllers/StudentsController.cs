using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class StudentsController : ApiController
    {
        List<Students> stud = new List<Students>();

       
       
        public StudentsController()
        {
            stud.Add(new Students { Id = 1, FirstName = "Mehul", LastName = "Patil", Major = "MIS" });
            stud.Add(new Students { Id = 2, FirstName = "Rohit", LastName = "Morajkar", Major = "CS" });
            stud.Add(new Students { Id = 3, FirstName = "Sachin", LastName = "Kale", Major = "MIS" });
            stud.Add(new Students { Id = 4, FirstName = "Abhijit", LastName = "Kale", Major = "CS" });
        }

        [Route("api/Students/FirstNames/{userId:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId)
        {
            List<string> output = new List<string>();

            foreach (var st in stud)
            {
                if(st.Id==userId)
                output.Add(st.FirstName);
            }

            return output;
        }





        [Route("api/Students/FirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach(Students st in stud)
            {

                output.Add(st.FirstName);
            }

            return output;
        }
    

        // GET: api/Students
        public List<Students> Get()
        {
           
            return stud;
        }

        // GET: api/Students/5
        public Students Get(int id)
        {
            
            Students str = stud.Where(x=>x.Id==id).FirstOrDefault();
            return str;
        }

        // POST: api/Students
        public void Post(Students val)
        {
           stud.Add(val);
        }

        // PUT: api/Students/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
            stud.Remove(stud.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
