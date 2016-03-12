using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.DefectsModule.Models
{
    public interface IDefectCRUD
    {
        IEnumerable<Defect> ListDefectsByProductTypeId(int productTypeId);
        Defect ListDefectById(int defectId);
        bool Add(Defect defect);
        bool Remove(int defectId);
    }
}
