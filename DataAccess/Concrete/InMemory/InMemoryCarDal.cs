using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 20000, Description = "İkinci El", ModelYear = 1998 },
                new Car {Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 65000, Description ="Temiz kullanılmış", ModelYear=1970},
                new Car {Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 97000, Description = "Sahibinden Satılık", ModelYear = 2000 },
                new Car {Id = 4, BrandId = 2, ColorId = 4, DailyPrice = 72000, Description = "Temiz kullanılmış", ModelYear = 2020 },
                new Car {Id = 5, BrandId = 3, ColorId = 5, DailyPrice = 10000, Description = "Temiz kullanılmış", ModelYear = 2002 },
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("{0} model araba {1} TL fiyatı ile eklendi.", car.ModelYear, car.DailyPrice);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Func<Car, bool> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Func<Car, bool> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

       

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}
