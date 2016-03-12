using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.WarrantyModule.Models
{
    public interface IWarrantyCRUD
    {
        bool AddWarrantyForInventoryItem(string inventoryItemIdentifier);
        bool IsValidWarrantyForInventoryItem(string inventoryItemIdentifier);
        IEnumerable<Warranty> ListWarrantiesForCustomer(Guid customerId);
    }
}
