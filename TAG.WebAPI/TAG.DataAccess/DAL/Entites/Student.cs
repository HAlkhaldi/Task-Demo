using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAG.DataAccess.DAL.Entites
{
  
    [Table("Student")]
   public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(150)]
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

        [Required]
        [MaxLength(50)]
        public string StudentGender { get; set; }
    }
}
