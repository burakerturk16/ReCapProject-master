using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{ 
            
                new Car{Id = 1 , BrandId = 1 , ColorId = 1 , DailyPrice = 1000 , ModelYear = 2015 , Description ="100 beygir gücü Otomatik vites"},
                new Car{Id = 2 , BrandId = 1 , ColorId = 3 , DailyPrice = 2000 , ModelYear = 2016 , Description ="300 beygir gücü Otomatik vites"},
                new Car{Id = 3 , BrandId = 2 , ColorId = 6 , DailyPrice = 3000 , ModelYear = 2014 , Description ="400 beygir gücü Düz vites"},
                new Car{Id = 4 , BrandId = 4 , ColorId = 2 , DailyPrice = 500 , ModelYear =  2015 , Description ="200 beygir gücü Manuel"},
                new Car{Id = 5 , BrandId = 2 , ColorId = 2 , DailyPrice = 600 , ModelYear =  2019 , Description ="100 beygir gücü Düz vites"},
                new Car{Id = 6 , BrandId = 7 , ColorId = 1 , DailyPrice = 10000 , ModelYear = 2010 , Description ="100 beygir gücü Otomatik vites"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Araba kayıt edildi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            Console.WriteLine("Araba kaydı silindi");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int brandId)
        {

            return _cars.Where(b => b.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            Console.WriteLine(car.Description + " Updated");
        }
    }
}
