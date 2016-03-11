using System.Collections.Generic;

namespace ECRAdmin.Product.Models
{
    public interface IProductCRUD<T>
    {
        bool Add(T product);
        bool Remove(T product);
        IEnumerable<T> ListAll();
        bool AddMultiple(IEnumerable<T> products);
    }
}
