using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string EmailAddress { get; set; }

        public ICollection<BorrowRequests> Borrowers { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
