using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.CustomerCRUD.Models
{
    public class Customer
    {
        public string CompanyName { get; set; }
        public Address CompanyAddress { get; set; }
    }
}
