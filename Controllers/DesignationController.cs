using InventoryManagementSystem.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class DesignationController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Designation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GETList()
        {  


            var designation = unitOfWork.DesignationRepository.GetAll();
            return Json(designation);
        }
    }
}