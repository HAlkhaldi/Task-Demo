using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TAG.DataAccess.DAL.Entites;
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
        public IHttpActionResult GetAll()
        {
            List<StudentDTO> studentDTOModel = new List<StudentDTO>();
            IEnumerable<Student> students = _studentServices.GetAll();
            AutoMapper.Mapper.Map(students ,studentDTOModel);
            return Ok(studentDTOModel);
        }
        
        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            StudentDTO studentDTOModel = new StudentDTO();
            Student students = _studentServices.GetById(Id);
            AutoMapper.Mapper.Map(students, studentDTOModel);

            return Ok(studentDTOModel);
        }

        [HttpPost]
        public bool Add([FromBody]StudentDTO studentDTO)
        {
            if (ModelState.IsValid)
            {
                Student studentModel = new Student();
                AutoMapper.Mapper.Map(studentDTO, studentModel);
                _studentServices.Add(studentModel);
            }
            return true;
        }

        [HttpPut]
        public bool Edit([FromBody]StudentDTO studentDTO)
        {
            Student studentModel = new Student();
            AutoMapper.Mapper.Map(studentDTO, studentModel);
            _studentServices.Edit(studentModel);
            return true;
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            var status = _studentServices.Delete(id);
            return status;
        }
    }
}
