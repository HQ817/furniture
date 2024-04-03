using System;
using System.ComponentModel.DataAnnotations;

namespace Internet.Models
{


// Supplier(int id, String supplierName, String address, String postCode, String phone, DateTime CreatedAt)

    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        public int SupplierId {get; set;}
        public string? SupplierName { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public string? Phone { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}