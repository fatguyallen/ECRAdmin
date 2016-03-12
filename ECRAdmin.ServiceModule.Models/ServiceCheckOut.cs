using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ServiceModule.Models
{
    public class ServiceCheckOut
    {
        public Guid ServiceCheckInId { get; set; }
        public DateTime Date { get; set; }
    }
}
