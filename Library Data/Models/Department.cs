using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string DepartmentName { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string EmailAddress { get; set; }

        public ICollection<BorrowRequests> Borrowers { get; set; }
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
