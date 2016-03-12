using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ServiceModule.Models
{
    public interface IServiceCRUD
    {
        IEnumerable<ServiceCheckIn> ListAllCheckIns();
        IEnumerable<ServiceCheckOut> ListAllCheckOuts();
        bool CheckIn(ServiceCheckIn checkIn);
        bool CheckOut(ServiceCheckOut checkOut);
        CustomerServiceStatus GetCustomerServiceStatus(Guid customerId);
    }
}
