using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapDatabaseContext context = new ReCapDatabaseContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars on re.Id equals c.Id
                             join cu in context.Customers on re.CustomerId equals cu.CustomerId
                             join u in context.Users on cu.UserId equals u.Id
                             select new RentalDetailDto
                             { 
                                 RentalId = re.RentalId,
                                 CustomerName = cu.CompanyName,
                                 Id = c.Id,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 FirstName = u.FirstName + " " + u.LastName
                             };
                
                return result.ToList();

            }
        }
    }
}
