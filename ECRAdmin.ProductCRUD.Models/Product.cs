using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ProductCRUD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public GeneralSpecifications GeneralSpecifications { get; set; }
    }
}
