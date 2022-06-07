using InventoryManagementSystem.DAL.UnitOfWork;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class GRNController : Controller
    {
        InventoryManagementSystemEntities context =new InventoryManagementSystemEntities();
        private  UnitOfWork unitOfWork = new UnitOfWork();
        // GET: GRN
        public ActionResult Index()
        {
            var list = unitOfWork.GrnRepository.GetAll();
            return View(list);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult GetList()
        {
           var list= unitOfWork.GrnRepository.GetAll();


            return Json(list);
        }
        public ActionResult Create(GRN Obj)
        {
           var a= context.GRNs.Add(Obj);
            int b = context.SaveChanges();
            return Json(a);
        }
        public ActionResult Update(GRN Obj)
        {
            return View();
        }
        public ActionResult Delete(int ID)
        {
            var obj = context.GRNDetails.Where(x => x.GRNID == ID).ToList();
          
            var obj2 = context.GRNs.FirstOrDefault(x => x.ID == ID);
            foreach (var o in obj) { context.Entry(o).State = System.Data.EntityState.Deleted; }
           
           
            var result = context.Entry(obj2).State = System.Data.EntityState.Deleted;
            context.SaveChanges();

            return Json(result);
        }
    }
}