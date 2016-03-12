using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Service.Models
{
    public class CustomerServiceStatus
    {
        public Guid CustomerId { get; set; }
        public IEnumerable<ItemServiceHistory> ItemServiceHistories { get; set; }
    }

    public class ItemServiceHistory
    {
        public string InventoryItemIdentifier { get; set; }
        public IEnumerable<ItemServiceStatus> ServiceStatuses { get; set; }
    }

    public class ItemServiceStatus
    {
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
    }
}
