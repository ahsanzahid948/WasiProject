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

        private GenericRepository<ReturnVoucher> returnVoucherRepository;
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
        private GenericRepository<RefDesignation> designationRepository;
        public GenericRepository<RefDesignation> DesignationRepository
        {
            get
            {
                if (this.designationRepository == null)
                {
                    this.designationRepository = new GenericRepository<RefDesignation>(context);
                }
                return designationRepository;
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

        public GenericRepository<ReturnVoucher> ReturnVoucherRepository
        {
            get
            {
                if (this.returnVoucherRepository == null)
                {
                    this.returnVoucherRepository = new GenericRepository<ReturnVoucher>(context);
                }
                return returnVoucherRepository;
            }
        }
        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}