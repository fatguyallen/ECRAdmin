using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.Defect.Models
{
    public interface IDefectCRUD
    {
        IEnumerable<Defect> ListDefectsByProductType(ProductType productType);
        Defect ListDefectById(int defectId);
        bool Add(Defect defect);
        bool Remove(int defectId);
    }
}
