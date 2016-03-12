using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Warranty.Models
{
    public interface IWarrantyCRUD
    {
        bool AddWarrantyForInventoryItem(string inventoryItemIdentifier);
        bool IsValidWarrantyForInventoryItem(string inventoryItemIdentifier);
        IEnumerable<Warranty> ListWarrantiesForCustomer(Guid customerId);
    }
}
