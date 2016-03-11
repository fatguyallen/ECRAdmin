namespace ECRAdmin.Inventory.Models
{
    public class InventoryItem<T>
    {
        public string Identifier { get; set; }
        public T ProductKey { get; set; }
    }
}
