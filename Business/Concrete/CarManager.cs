using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();   
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(b => b.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
