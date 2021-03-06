using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        Car GetById(int carId);
        List<CarDetailDto> GetCarDetails();
    }
}
