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

            //CarTest();
            //ColorTest();
            //BrandTest();
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car{
                ModelYear = 2001,
                DailyPrice = 100,
                Description = "Manuel ",
                BrandId = 5,
                ColorId = 5

            }); 




        }

      

    }
}
