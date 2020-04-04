using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAG.DataAccess.DAL;
using TAG.WebAPI.GenericRepository;

namespace TAG.DataServices.Student
{
    public class StudentServices
    {
        private IGenericRepository<TAG.DataAccess.DAL.Entites.Student> repository = null;
        public StudentServices()
        {
            this.repository = new GenericRepository<TAG.DataAccess.DAL.Entites.Student>();
        }
        //public StudentServices(IGenericRepository<TAG.DataAccess.DAL.Entites.Student> repository)
        //{
        //    this.repository = repository;
        //}

        public IEnumerable<TAG.DataAccess.DAL.Entites.Student> GetAll()
        {
            var data = repository.GetAll();
            return data;
        }
        public bool Add(TAG.DataAccess.DAL.Entites.Student model)
        {
            repository.Add(model);
            repository.Save();
            return true;
        }
        public TAG.DataAccess.DAL.Entites.Student Edit(TAG.DataAccess.DAL.Entites.Student model)
        {
            repository.Edit(model);
            repository.Save();
            return model;
        }
        public bool Delete(int ID)
        {
            repository.Delete(ID);
            repository.Save();
            return true;
        }
        public TAG.DataAccess.DAL.Entites.Student GetById(int ID)
        {
            TAG.DataAccess.DAL.Entites.Student model = repository.GetById(ID);
            return model;
        }
    }
}
