using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Firstname { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Middlename { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Lastname { get; set; }

        [Required]
        [MaxLength(40)]
        // Hash the passwords everytime
        public string Password { get; set; }

        [ForeignKey("Grade")]
        public int GradeID { get; set; }
        public Grade Grade { get; set; }

        [ForeignKey("Student")]
        public string StudentID { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        public Staff Staff { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string EmailAddress { get; set; }
    }
}
