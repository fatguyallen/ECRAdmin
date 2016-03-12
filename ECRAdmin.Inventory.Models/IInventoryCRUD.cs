using System.Collections.Generic;

namespace ECRAdmin.Inventory.Models
{
    public interface IInventoryCRUD
    {
        bool CheckIn(InventoryItem product);
        bool CheckOut(InventoryItem product);
        IEnumerable<InventoryItem> GetBalance();
        IEnumerable<InventoryItem> GetCheckIns();
        IEnumerable<InventoryItem> GetCheckOuts();
    }
}
