using InventoryManagementSystem.DAL.UnitOfWork;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class RequisitionFormController : Controller
    {
        InventoryManagementSystemEntities context = new InventoryManagementSystemEntities();
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: RequisitionForm
        public ActionResult Index()
        {
            var list = context.RequisitionForms.ToList();
            return View(list);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult View(int ID)
        {
            var list = context.RequisitionForms.FirstOrDefault(x => x.ID == ID);

            return View(list);
        }

        public ActionResult GetList()
        {
            var list = context.RequisitionForms.ToList();


            return Json(list,JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create(RequisitionForm Obj)
        {
            var a = context.RequisitionForms.Add(Obj);
            int b = context.SaveChanges();
            return Json(a);
        }
        public ActionResult Update(GRN Obj)
        {
            return View();
        }

        public ActionResult Delete(int  Id)
        {
            var obj = context.RequisitionFormDetails.Where(x => x.RequisitionFormID == Id).ToList();

            var obj2 = context.RequisitionForms.FirstOrDefault(x => x.ID == Id);
            foreach (var o in obj) { context.Entry(o).State = System.Data.EntityState.Deleted; }


            var result = context.Entry(obj2).State = System.Data.EntityState.Deleted;
            context.SaveChanges();
            return Json(result);
        }
    }
}