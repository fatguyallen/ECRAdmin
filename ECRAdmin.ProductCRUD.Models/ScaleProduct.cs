using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ProductCRUD.Models
{
    public class ScaleProduct
    {
        public Product Product { get; set; }
        public ScaleSpecifications Specifications { get; set; }
    }
}
