using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ServiceModule.Models
{
    public interface IServiceValidationRules
    {
        bool CheckInIsValid(ServiceCheckIn checkInRequest);
        bool CheckOutIsValid(ServiceCheckOut checkOutRequest);
    }
}
