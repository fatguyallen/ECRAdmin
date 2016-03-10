using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.InventoryCRUD.Models
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
