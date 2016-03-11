using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ServiceRequestCRUD.Models
{
    public class ServiceRequest
    {
        public string InventoryItemIdentifier { get; set; }
        public DateTime Date { get; set; }
    }
}
