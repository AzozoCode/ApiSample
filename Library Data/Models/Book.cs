using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Data.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public BookCategory Category { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Author { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }
    }
}
