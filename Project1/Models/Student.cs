using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Addrss { get; set; } = null!;
        [Required]
        public string Contact { get; set; } = null!;
    }
}
