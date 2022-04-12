using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.DAL.Generic
{
    public interface IGenericRepository<T>
    {
        T GetByID(int id);
        int Insert(T obj);
        int update(T obj);
        int Delete(T obj);
        T SoftDelete(T obj);
        List<T> GetAll();



    }
}