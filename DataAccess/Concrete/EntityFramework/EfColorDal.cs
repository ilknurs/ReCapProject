using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapDatabaseContext context = new ReCapDatabaseContext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapDatabaseContext context = new ReCapDatabaseContext())
            {
                var deletedColor = context.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Func<Color, bool> filter)
        {
            using (ReCapDatabaseContext reCapDatabaseContext = new ReCapDatabaseContext())
            {
                return reCapDatabaseContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Func<Color, bool> filter = null)
        {
            using (ReCapDatabaseContext context = new ReCapDatabaseContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public List<Color> GetAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            using (ReCapDatabaseContext context = new ReCapDatabaseContext())
            {
                var updatedColor = context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
