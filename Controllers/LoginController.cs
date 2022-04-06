using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using InventoryManagementSystem.DAL.UnitOfWork;
using InventoryManagementSystem.Models;

namespace PcamericaWebPortal.Controllers
{
    public class LoginController : Controller
    {
        InventoryManagementSystemEntities context = new InventoryManagementSystemEntities();
        UnitOfWork unitOfWork =new UnitOfWork();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserSignIn(string email, string password)
        {
            try
            {
                var result = unitOfWork.UserRepository.GetAll();
                var user = result.FirstOrDefault(x => x.EmailAddress == email && x.Password == password);


                if (user == null)
                {
                    return Json(0);
                }
                else
                {
                    Session["CompanyID"] = user.CompanyID;
                    Session["EmailAddress"] = user.EmailAddress;
                    Session["EntryUserID"] = user.EntryUserID;
                    Session["FirstName"] = user.FirstName;
                    Session["ID"] = user.ID;
                    Session["IsAdmin"] = user.IsAdmin;
                    Session["LastName"] = user.LastName;
                    Session["EmailAddress"] = user.EmailAddress;
                    Session["Password"] = user.Password;
                    Session["UserProfileImage"] = user.UserProfileImage;
                    Session["SessionExist"] = 1;
                    return Json(user);
                }
            }

            catch (Exception ex) { return Json("errorr"); }
        }


        public ActionResult LogOff()
        {
            try
            {
                //Clear Session Values

                Session.Clear();
                Session.Abandon();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            // Login Again
            return this.RedirectToAction("Index", "Login");
        }

        public ActionResult ChangePassword(string PasswordOld,string PasswordNew,string PasswordConfirm)
        {
            try
            {
                //Clear Session Values
                if (PasswordNew == PasswordConfirm)
                {
                    var result = unitOfWork.UserRepository.GetAll();
                    var user = result.FirstOrDefault(x =>  x.Password == PasswordOld);
                    if (user != null)
                    {
                        user.Password = PasswordNew;
                        int a = unitOfWork.SaveChanges();
                        return Json(a);

                    }
                    else {
                        return Json(0);

                    }
                   
                }
                else return Json(5);


            }
            catch (Exception ex)
            {

                throw ex;
            }

            
            
        }

    }
}