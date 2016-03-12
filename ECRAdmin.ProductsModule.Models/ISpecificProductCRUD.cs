using System.Collections.Generic;

namespace ECRAdmin.ProductsModule.Models
{
    public interface ISpecificProductCRUD<T>
    {
        bool Add(T product);
        bool Remove(int productId);
        IEnumerable<T> ListAll();
        bool AddMultiple(IEnumerable<T> products);
        T ListById(int productId);
    }
}
