using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TAG.DataServices.Student;
using TAG.DataServices.Student.BaseModel;

namespace TAG.WebAPI.Web_API
{
    public class StudentsController : ApiController
    {
        private StudentServices _studentServices;
        public StudentsController()
        {
            _studentServices = new StudentServices();
        }

        [HttpGet]
        [ActionName("GetAllStudents")]
        public IHttpActionResult GetAllStudents()
        {

            var data = _studentServices.GetAll();
            return Ok(data);
        }
    
    }
}
