using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                 Console.WriteLine(car.Id);
            }
            carManager.Add(new Car {  DailyPrice = 0, ModelYear = 2015, Description = "Otomatik Vites" });


            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 5, BrandName = "a" });


            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {  ColorName = "black" });
            
            

        }
    }
}
