using System;
using System.ComponentModel.DataAnnotations;

namespace Internet.Models
{

    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
    }
}