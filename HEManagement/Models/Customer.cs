using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace HEManagement.Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
       
    }
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> Movies { get; set; }
    }
}