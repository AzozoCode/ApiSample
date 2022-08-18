using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class BorrowRequests
    {
        [Key]
        public int RequestID { get; set; }

        [ForeignKey("Student")]
        public string StudentID { get; set; }
        public Student Student { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Lastname { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Firstname { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Middlename { get; set; }

        [ForeignKey("Grade")]
        public int GradeID { get; set; }
        public Grade Grade { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        public DateTime DateRequested { get; set; }

        public ICollection<BorrowedBooks> BorrowedBooks { get; set; }
        public ICollection<DeclinedRequests> DeclinedRequests { get; set; }

    }
}
