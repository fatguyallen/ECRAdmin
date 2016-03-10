using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.InventoryCRUD.Models
{
    public class InventoryItem<T>
    {
        public string Identifier { get; set; }
        public T ProductKey { get; set; }
    }
}
