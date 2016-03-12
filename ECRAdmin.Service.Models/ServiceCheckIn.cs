using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Service.Models
{
    public class ServiceCheckIn
    {
        public Guid Id { get; set; }
        public string InventoryItemIdentifier { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
        public DefectDetails DefectDetails { get; set; }
    }

    public class DefectDetails
    {
        public int DefectId { get; set;}
        public string Comment { get; set; }
    }
}
