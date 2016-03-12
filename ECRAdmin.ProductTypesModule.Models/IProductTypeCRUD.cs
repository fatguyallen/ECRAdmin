using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ProductTypesModule.Models
{
    public interface IProductTypeCRUD
    {
        bool Add(ProductType productType);
        bool Remove(int productTypeId);
        IEnumerable<ProductType> ListAll();
    }
}
