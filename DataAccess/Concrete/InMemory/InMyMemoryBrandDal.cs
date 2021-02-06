using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMyMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMyMemoryBrandDal()
        {
            _brands = new List<Brand> {
            new Brand{BrandId = 1, BrandName = "TESLA"},
            new Brand{BrandId = 1, BrandName = "TESLA"},
            new Brand{BrandId = 1, BrandName = "TESLA" }
            };
        }

        public void Add(Brand brand)
        {
            brand.BrandId = _brands.Last().BrandId + 1;
            _brands.Add(brand);
            Console.WriteLine("{0} marka eklendi.",brand.BrandId);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
            Console.WriteLine("{0} markası silindi.",brandToDelete.BrandName);

        }

        public Brand Get(Func<Brand, bool> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Func<Brand, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }


        /*
 public void Update(Brand brand)
 {
    Brand brandToUpdate = new _brands.SingleOrDefault(b => brand.BrandId == brand.BrandId);
    brandToUpdate.BrandName = brand.BrandName;
    Console.WriteLine("Güncellenen markalar"+ "{0}-{1}", brandToUpdate.BrandId, brandToUpdate.BrandName);
 }*/
    }

}
