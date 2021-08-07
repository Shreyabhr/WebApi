using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentWebApi.Models
{
    public class StudentDTO
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int RollNo { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}")]
        public string Email { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public bool IsMale { get; set; }
    }
}