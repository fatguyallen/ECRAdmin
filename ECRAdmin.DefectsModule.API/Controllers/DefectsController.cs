using ECRAdmin.DefectsModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ECRAdmin.Helpers;

namespace ECRAdmin.DefectsModule.API.Controllers
{
    public class DefectsController : ApiController
    {
        IEnumerable<Defect> _defects = new[] { new Defect { Id = 1, ProductTypeId = 2, Description = "assafds" } };

        public IEnumerable<Defect> GetAllDefects(int? productTypeId = null)
        {
            return productTypeId != null ? _defects.Where(d => d.ProductTypeId == productTypeId) : _defects;
        }

        public IHttpActionResult GetDefect(int id)
        {
            return _defects.FirstOrDefault(d => d.Id == id)
                .Apply(d => d != null ? (IHttpActionResult)Ok(d) : NotFound());
        }
    }
}
