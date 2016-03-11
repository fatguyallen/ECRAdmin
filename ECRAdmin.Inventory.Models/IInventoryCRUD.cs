using System.Collections.Generic;

namespace ECRAdmin.Inventory.Models
{
    public interface IInventoryCRUD
    {
        bool Add(InventoryItem product);
        bool Remove(InventoryItem product);
        IEnumerable<InventoryItem> GetBalance();
        IEnumerable<InventoryItem> GetIns();
        IEnumerable<InventoryItem> GetOuts();
    }
}
