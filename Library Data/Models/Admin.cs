using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace Library_Data.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Username { get; set; }

        [Required]
        [MaxLength(40)]
        // Hash the passwords everytime
        public string Password { get; set; }

        //public string MakeHashPassword
        //{
        //    set
        //    {
        //        SHA256Managed hasher = new();
        //        byte[] unhashed = System.Text.Encoding.Unicode.GetBytes(Password);
        //        byte[] hashed = hasher.ComputeHash(unhashed);
        //        _ = Convert.ToBase64String(hashed);
        //    }
        //}

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Contact { get; set; }

        [Required]
        [MaxLength(40)]
        public string EmailAddress { get; set; }
    }
}
