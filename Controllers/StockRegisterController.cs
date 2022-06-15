using InventoryManagementSystem.DAL.UnitOfWork;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class StockRegisterController : Controller
    {
        InventoryManagementSystemEntities context = new InventoryManagementSystemEntities();
        private UnitOfWork unitOfWork = new UnitOfWork();
        
        public ActionResult Index()
        {
            var list = context.StokeRegisters.ToList();
            return View(list);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult View(int ID)
        {
            var list = context.StokeRegisters.FirstOrDefault(x => x.ID == ID);

            return View(list);
        }
        public ActionResult GetList()
        {
            var list = unitOfWork.GrnRepository.GetAll();


            return Json(list);
        }
        public ActionResult Create(StokeRegister Obj)
        {
            try
            {
                var a = context.StokeRegisters.Add(Obj);
                int b = context.SaveChanges();
                return Json(b);
            }
            catch (Exception ex) { return Json(""); }
        }
        public ActionResult Update(GRN Obj)
        {
            return View();
        }
        public ActionResult Delete(int ID)
        {

            try
            {
                var obj = context.StokeRegisters.SingleOrDefault(x => x.ID == ID);

              


                var result = context.Entry(obj).State = System.Data.EntityState.Deleted;
                context.SaveChanges();
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json("");

            }

        }
    }
}