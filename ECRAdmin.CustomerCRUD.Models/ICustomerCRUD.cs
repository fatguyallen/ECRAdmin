using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.CustomerCRUD.Models
{
    public interface ICustomerCRUD
    {
        bool Add(Customer customer);
        bool Remove(Customer customer);
        IEnumerable<Customer> ListAll();
    }
}
