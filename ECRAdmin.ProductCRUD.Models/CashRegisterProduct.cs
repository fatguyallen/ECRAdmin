using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ProductCRUD.Models
{
    public class CashRegisterProduct
    {
        public Product Product { get; set; }
        public CashRegisterSpecifications Specifications { get; set; }
    }
}
