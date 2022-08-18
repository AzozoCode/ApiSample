using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string FacultyName { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string EmailAddress { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}
