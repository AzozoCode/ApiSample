using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class BorrowedBooks
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("BorrowRequests")]
        public int RequestID { get; set; }
        public BorrowRequests BorrowRequests { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Lastname { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Firstname { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Middlename { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        public DateTime DateBorrowed { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
