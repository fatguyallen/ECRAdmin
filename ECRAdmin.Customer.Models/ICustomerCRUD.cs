using System;
using System.Collections.Generic;

namespace ECRAdmin.Customer.Models
{
    public interface ICustomerCRUD
    {
        bool Add(Customer customer);
        bool Remove(Guid customerId);
        IEnumerable<Customer> ListAll();
    }
}
