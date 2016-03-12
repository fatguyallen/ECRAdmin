using System;
using System.Collections.Generic;

namespace ECRAdmin.CustomersModule.Models
{
    public interface ICustomerCRUD
    {
        bool Add(Customer customer);
        bool Remove(Guid customerId);
        IEnumerable<Customer> ListAll();
    }
}
