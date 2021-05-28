using System;

using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System.Collections.Generic;
using DataAccess.Concrete.EntityFrameWork;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddedEntities();
            //CarGet();
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
            
        }

        private static void CarGet()
        {
            ICarDal carDal = new EFCarDal();
            CarManager carManager = new CarManager(carDal);
            foreach (var car in carDal.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }

            var carGet = carDal.Get((x => x.Id == 2));
            Console.WriteLine("\n" + carGet.Id + carGet.Name + " " + carGet.BrandId + " " + carGet.ColorId + " " + carGet.DailyPrice + " " + carGet.ModelYear + " " + carGet.Description);
            Console.WriteLine("BrandId");
            foreach (var getBrand in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("\n" + getBrand.Id + " " + getBrand.DailyPrice);
            }
            Console.WriteLine("ColorId");
            foreach (var getColor in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("\n" + getColor.ColorId + " " + getColor.ModelYear);
            }
        }

        private static void AddedEntities()
        {
            ICarDal carDal = new EFCarDal();
            CarManager carManager = new CarManager(carDal);

            Car car1 = new Car { Id = 2, BrandId = 1, ColorId = 3, Name = "A", DailyPrice = 2000, ModelYear = 2016, Description = "SA" };
            Car car2 = new Car { Id = 3, BrandId = 2, ColorId = 6, Name = "B", DailyPrice = 3000, ModelYear = 2014, Description = "SA" };
            Car car3 = new Car { Id = 4, BrandId = 3, ColorId = 2, Name = "A", DailyPrice = 500, ModelYear = 2015, Description = "SA" };
            Car car4 = new Car { Id = 5, BrandId = 1, ColorId = 2, Name = "D", DailyPrice = 600, ModelYear = 2019, Description = "SA" };
            Car car5 = new Car { Id = 6, BrandId = 3, ColorId = 1, Name = "E", DailyPrice = 10000, ModelYear = 2010, Description = "SA" };

            carDal.Add(car1); carDal.Add(car2); carDal.Add(car3); carDal.Add(car4); carDal.Add(car5);

            IBrandDal brandDal = new EFBrandDal();
            Brand brand1 = new Brand { Id = 1, Name = "Opel" };
            Brand brand2 = new Brand { Id = 2, Name = "Toyota" };
            Brand brand3 = new Brand { Id = 3, Name = "Renualt" };

            brandDal.Add(brand1); brandDal.Add(brand2); brandDal.Add(brand3);

            IColorDal colorDal = new EFColorDal();
            Color color1 = new Color { Id = 1, Name = "Siyah" };
            Color color2 = new Color { Id = 2, Name = "Beyaz" };
            Color color3 = new Color { Id = 3, Name = "Mavi" };
            Color color4 = new Color { Id = 4, Name = "Kirmizi" };
            Color color5 = new Color { Id = 5, Name = "Yesil" };

            colorDal.Add(color1); colorDal.Add(color2); colorDal.Add(color3); colorDal.Add(color4); colorDal.Add(color5);
        }
    }
}
