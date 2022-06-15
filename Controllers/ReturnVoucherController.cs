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
        public ActionResult View(int ID)
        {
            var list = context.ReturnVouchers.FirstOrDefault(x => x.ID == ID);

            return View(list);
        }
        public ActionResult GetUpdate(int ID)
        {
            var list = context.ReturnVouchers.FirstOrDefault(x => x.ID == ID);

            return View(list);
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
        public ActionResult Update(ReturnVoucher Obj)
        {
            try
            {
                var obj = context.ReturnVoucherDetails.Where(x => x.ReturnVoucherID == Obj.ID).ToList();

                var obj2 = context.ReturnVouchers.FirstOrDefault(x => x.ID == Obj.ID);
                foreach (var o in obj) { context.Entry(o).State = System.Data.EntityState.Deleted; }


                var result = context.Entry(obj2).State = System.Data.EntityState.Deleted;
                context.SaveChanges();

                Obj.ID = 0;
                var a = context.ReturnVouchers.Add(Obj);
                int b = context.SaveChanges();


                return Json(b);


            }
            catch (Exception ex)
            {
                return Json("");

            }
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