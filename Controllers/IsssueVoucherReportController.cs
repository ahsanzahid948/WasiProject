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
                    int? demandtotal=0, issuetotal=0, remainingtotoal=0;

                    foreach (var n in a) {
                        demandtotal = demandtotal +int.Parse( n.QTYDemand);

                        issuetotal = issuetotal + int.Parse(n.QTYIssued);
                        remainingtotoal = remainingtotoal + n.QTYRemaining;
                    }



                    ReportDocument rd = new ReportDocument();
                rd.Load(Server.MapPath("~/IssueVoucherReport.rpt"));
                    string printedby = Session["FirstName"].ToString();
                    rd.SetDataSource(a);
                    rd.SetParameterValue("CompanyName", "National Institute Of Electronic");
                    rd.SetParameterValue("AddressPhone", "H-9, Islamabad, Islamabad Capital Territory");
                    rd.SetParameterValue("PrintedBy", printedby);
                    rd.SetParameterValue("QTYDemandTotal", demandtotal);
                    rd.SetParameterValue("QTYIssuedTotal", issuetotal);
                    rd.SetParameterValue("QTYRemainingTotal", remainingtotoal);
                    rd.SetParameterValue("logo", "");
                    rd.SetParameterValue("Name", Name);
                    Response.Buffer = false;
                    Response.ClearContent();
                    Response.ClearHeaders();

               
                    rd.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                    rd.PrintOptions.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(5, 5, 5, 5));
                    rd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;

                    Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                    stream.Seek(0, SeekOrigin.Begin);

                    return File(stream, "application/pdf", "IssueVoucherReport.pdf");

                }



                else { return Content("No Record Found"); }

            }

            catch (Exception ex) { return Content("No Record Found"); }

        }
     
    }
}