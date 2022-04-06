using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.DAL.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private InventoryManagementSystemEntities context;
        internal DbSet<T> dbSet;
        public GenericRepository(InventoryManagementSystemEntities context)
        {
            
            this.context = context;
            this.dbSet = context.Set<T>();

        }
        public T Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            var result = dbSet;
            return result.ToList();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T obj)
        {
            int result = 0;
            try {
                dbSet.Add(obj);
                 result = context.SaveChanges();
            }
            catch (Exception ex) { 
            
            
            }
            return result;
                
        }

        public T SoftDelete(T obj)
        {
            throw new NotImplementedException();
        }

        public T update(T obj)
        {
            throw new NotImplementedException();
        }

       
    }
}