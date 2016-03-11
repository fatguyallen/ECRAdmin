using System.Collections.Generic;

namespace ECRAdmin.Customer.Models
{
    public interface ICustomerCRUD
    {
        bool Add(ECRAdmin.Customer.Models.Customer customer);
        bool Remove(ECRAdmin.Customer.Models.Customer customer);
        IEnumerable<Customer> ListAll();
    }
}
