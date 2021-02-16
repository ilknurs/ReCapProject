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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine("-----------------------ReCap Projesi-----------------------");
        
            Console.WriteLine("\nAraba Markaları\n");
            BrandGetAllTest(brandManager);
            Console.WriteLine("\nAraba Renkleri");
            ColorGetAllTest(colorManager);
            

        }

        private static void ColorGetAllTest(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine("ColorId : {0}\nColorName : {1}\n", color.ColorId, color.ColorName);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandGetAllTest(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine("BrandId : {0}\nBrandName : {1}\n", brand.BrandId, brand.BrandName);
                }
                Console.WriteLine(result.Message);
            }
            else
                Console.WriteLine(result.Message);
        }

    

        private static void CarGetAllTest(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0}\t\t{1}\t{2}\t\t{3}", car.Id, car.BrandId, car.ColorId, car.Description, car.ModelYear, car.DailyPrice);
                }
                Console.WriteLine(result.Message);
            }
            else
                Console.WriteLine(result.Message);
        }

        
       
    }
}
