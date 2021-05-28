using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> getAll()
        {
            return _brandDal.GetAll();
        }

        public Brand getById(int brandId)
        {
            return _brandDal.Get(b => b.Id == brandId);
        }
    }
}
