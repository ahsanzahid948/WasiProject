using InventoryManagementSystem.DAL.UnitOfWork;
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
            return View();
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult GetList()
        {
            var list = unitOfWork.GrnRepository.GetAll();


            return Json(list);
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
    }
}