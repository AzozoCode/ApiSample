using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string StaffName { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Faculty")]
        public int FacultyID { get; set; }
        public Faculty Faculty { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string EmailAddress { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<BorrowRequests> BorrowRequests { get; set; }
    }
}
