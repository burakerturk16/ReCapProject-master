
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}

//Bir araba nesnesi oluşturunuz. "Car"

//Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

//InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

