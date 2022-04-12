using InventoryManagementSystem.DAL.UnitOfWork;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class UserListController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        // GET: UserList
        public ActionResult Index()
        {



            return View();
        }


        public ActionResult Index2()
        {
            return View();
        }


        public ActionResult Delete(int ID)
        {
           var obj= unitOfWork.UserRepository.GetAll().FirstOrDefault(x=>x.ID==ID);
           int a= unitOfWork.UserRepository.Delete(obj);
            return Json(a);
        }

        public ActionResult GetTableSummary()
        {
          var result=  unitOfWork.UserRepository.GetAll().Where(x=>x.IsSuperAdmin!=true);
            return Json(result);
        }

        public ActionResult Create(RefUser refUser )
        {
            refUser.IsActive = true;
            refUser.EntryDate = DateTime.Now;
        var result=    unitOfWork.UserRepository.Insert(refUser);

            return Json(result);
        }
        

       public ActionResult Update(RefUser refUser)
        {
            refUser.IsActive = true;
            refUser.EntryDate = DateTime.Now;
            var result = unitOfWork.UserRepository.update(refUser);
            if (result == 1) { result = 2; }
            return Json(result);
        }


        public ActionResult GetUser(int ID)
        {
            var result = unitOfWork.UserRepository.GetAll().FirstOrDefault(x => x.ID == ID);
            return Json(result);
        }


    }
}