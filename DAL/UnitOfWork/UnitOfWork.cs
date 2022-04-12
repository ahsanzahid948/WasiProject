using InventoryManagementSystem.DAL.Generic;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.DAL.UnitOfWork
{
    public class UnitOfWork
    {
        private InventoryManagementSystemEntities context = new InventoryManagementSystemEntities();


        private GenericRepository<GRN> grnRepository;
        private GenericRepository<RefUser> userRepository;
        public GenericRepository<RefUser> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<RefUser>(context);
                }
                return userRepository;
            }
        }

        public GenericRepository<GRN> GrnRepository
        {
            get
            {
                if (this.grnRepository == null)
                {
                    this.grnRepository = new GenericRepository<GRN>(context);
                }
                return grnRepository;
            }
        }


        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}