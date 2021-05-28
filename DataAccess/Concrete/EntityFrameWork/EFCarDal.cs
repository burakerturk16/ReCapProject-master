using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.EntityFrameWork
{
    public class EFCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result = from c in reCapContext.Cars
                             join b in reCapContext.Brands
                             on c.BrandId equals b.Id
                             join co in reCapContext.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 CarName = c.Name,
                                 DailyPrice = c.DailyPrice,
                                 BrandName = b.Name,
                                 ColorName = co.Name

                             };


                return result.ToList();        
            }
           
        }

    }
}
