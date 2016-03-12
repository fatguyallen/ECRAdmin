using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Warranty.Models
{
    public class Warranty
    {
        public Guid Id { get; set; }
        public string InventoryItemIdentifier { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
