using InventoryManagementSystem.DAL.UnitOfWork;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class ReturnVoucherController : Controller
    {
        InventoryManagementSystemEntities context = new InventoryManagementSystemEntities();
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            List<ReturnVoucher> v = context.ReturnVouchers.ToList();
           
            return View(v);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult GetVoucherList()
        {
           

            return Json(1);
        }
        public ActionResult Create(GRN Obj)
        {
            var a = context.GRNs.Add(Obj);
            int b = context.SaveChanges();
            return Json(a);
        }
        public ActionResult Update(GRN Obj)
        {
            return View();
        }
        public ActionResult Delete(int ID)
        {

            var obj = context.ReturnVouchers.FirstOrDefault(x => x.ID == ID);
            var result = context.Entry(obj).State = System.Data.EntityState.Deleted;

            return Json(result);
        }
    }
}