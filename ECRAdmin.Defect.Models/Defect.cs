using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Defect.Models
{
    public class Defect
    {
        public int Id { get; set; }
        public ProductType ProductType { get; set; }
        public int Description { get; set; }
    }
}
