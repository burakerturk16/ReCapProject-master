using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService
    {
        List<Brand> getAll();
        Brand getById(int brandId);
    }
}
