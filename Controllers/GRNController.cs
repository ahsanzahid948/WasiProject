﻿using InventoryManagementSystem.DAL.UnitOfWork;
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
      private  UnitOfWork unitOfWork = new UnitOfWork();
        // GET: GRN
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
           var list= unitOfWork.GrnRepository.GetAll();


            return Json(list);
        }
        public ActionResult Create(GRN Obj)
        {
            return View();
        }
        public ActionResult Update(GRN Obj)
        {
            return View();
        }
    }
}