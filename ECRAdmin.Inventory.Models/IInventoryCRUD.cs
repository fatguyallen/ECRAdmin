using System.Collections.Generic;

namespace ECRAdmin.Inventory.Models
{
    public interface IInventoryCRUD<T>
    {
        bool Add(InventoryItem<T> product);
        bool Remove(InventoryItem<T> product);
        IEnumerable<InventoryItem<T>> GetBalance();
        IEnumerable<InventoryItem<T>> GetIns();
        IEnumerable<InventoryItem<T>> GetOuts();
    }
}
