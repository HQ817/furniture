using System;
using System.ComponentModel.DataAnnotations;

namespace Internet.Models
{

    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string? ProductCode { get; set; }
        public string? Type { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }
        public int QtyInStock { get; set; }
        public string? ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}