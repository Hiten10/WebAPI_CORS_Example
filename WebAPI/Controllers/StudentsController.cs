using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        private List<Student> _students;

        public StudentsController()
        {
            _students = new List<Student>
                {
                    new Student{RollNo=1,Name="Test",Section='A',Class="10",Email="test@mydomain.com"},
                    new Student{RollNo=2,Name="Test1",Section='A',Class="10",Email="test1@mydomain.com"}
                };
        }

        [Route("api/Students/All")]
        //[ActionName("All")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse<List<Student>>(HttpStatusCode.OK, _students);
        }

        public HttpResponseMessage Get(int id)
        {
            var student = _students.Where(s => s.RollNo.Equals(id)).FirstOrDefault();
            return Request.CreateResponse<Student>(HttpStatusCode.OK, student);
        }

        //public HttpResponseMessage Post()
        //{
        //}

        //public HttpResponseMessage Put()
        //{ 
        //}

        //public HttpResponseMessage Delete()
        //{
        //}
    }
}