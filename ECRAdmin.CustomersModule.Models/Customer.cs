using System;

namespace ECRAdmin.CustomersModule.Models
{
    public class Customer
    {
        public Guid Key { get; set; }
        public string CompanyName { get; set; }
        public Address CompanyAddress { get; set; }
    }
}
