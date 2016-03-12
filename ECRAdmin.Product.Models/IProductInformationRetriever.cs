using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Product.Models
{
    public interface IProductInformationRetriever
    {
        ProductType GetProductTypeById(int productId);
    }
}
