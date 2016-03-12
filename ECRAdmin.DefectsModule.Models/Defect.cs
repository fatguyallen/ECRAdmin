using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.DefectsModule.Models
{
    public class Defect
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public int Description { get; set; }
    }
}
