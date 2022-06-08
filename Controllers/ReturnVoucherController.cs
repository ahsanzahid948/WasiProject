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
        public ActionResult Create(ReturnVoucher Obj)
        {
            try
            {

                var a = context.ReturnVouchers.Add(Obj);
                int b = context.SaveChanges();
                return Json(a);
            }
            catch (Exception ex) {

                return Json("Error While Adding");

            }
        }
        public ActionResult Update(GRN Obj)
        {
            return View();
        }
        public ActionResult Delete(int ID)
        {
            try
            {
                var obj = context.ReturnVoucherDetails.Where(x => x.ReturnVoucherID == ID).ToList();

                var obj2 = context.ReturnVouchers.FirstOrDefault(x => x.ID == ID);
                foreach (var o in obj) { context.Entry(o).State = System.Data.EntityState.Deleted; }


                var result = context.Entry(obj2).State = System.Data.EntityState.Deleted;
                context.SaveChanges();
                return Json(result);
            }
            catch (Exception ex) {

                return Json("Error While Deleting");

            }
        }
    }
}