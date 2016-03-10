﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRAdmin.ProductCRUD.Models
{
    public interface IProductCRUD<T>
    {
        bool Add<T>(T product);
        bool Remove<T>(T product);
        IEnumerable<T> ListAll();
    }
}