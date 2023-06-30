using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Services.Services
{
    public class BaseServices<T> where T : class
    {
        ElectricStoreDBContext dbContext;
        DbSet<T> dbSet;
        public BaseServices()
        {
            dbContext = new ElectricStoreDBContext();
            dbSet = dbContext.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public bool Create(T entity)
        {
            try
            {
                dbSet.Add(entity);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                var tracker = dbContext.Attach(entity);
                tracker.State = EntityState.Modified;
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                dbSet.Remove(entity);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
