using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }

        [Required]
        [MaxLength(10)]
        public string GradeName { get; set; }

        public ICollection<BorrowRequests> Borrowers { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
