using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAG.DataAccess.DAL.Entites;
using TAG.DataServices.Student.BaseModel;

namespace TAG.WebAPI.Infrastructure
{
    public class AutomapperWebProfile:AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO,Student>();
        }
        public static void Run()
        {
            AutoMapper.Mapper.Initialize(a => {
                a.AddProfile<AutomapperWebProfile>();
            });
        }
    }
}