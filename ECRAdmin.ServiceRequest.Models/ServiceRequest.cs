using System;

namespace ECRAdmin.ServiceRequest.Models
{
    public class ServiceRequest
    {
        public string InventoryItemIdentifier { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
    }
}
