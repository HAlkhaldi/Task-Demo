using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAG.DataAccess.DAL.Entites;

namespace TAG.DataAccess.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=DBEntities")
        {

        }
        public DbSet<Student> Student { get; set; }
    }
}
