using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrystalDecisions.CrystalReports.Engine;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class IsssueVoucherReportController : Controller
    {
        InventoryManagementSystemEntities context = new InventoryManagementSystemEntities();
        // GET: IsssueVoucherReport
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowReport(String Name)
        {


            try {






                var a = context.IssueVoucherReport(Name).ToList();
                
                if (a.Count()>0)
                {
                    ReportDocument rd = new ReportDocument();
                rd.Load(Server.MapPath("~/IssueVoucherReport.rpt"));
             
                rd.SetDataSource(a.ToList());
                    
                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();
               

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "IssueVoucher.pdf");
                
                }
                else { return Content("No Record Found"); }

            }

            catch (Exception ex) { return Content("No Record Found"); }

        }
     
    }
}