using CrystalDecisions.CrystalReports.Engine;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class ReturnVoucherReportController : Controller
    {
        InventoryManagementSystemEntities context = new InventoryManagementSystemEntities();
        // GET: IsssueVoucherReport
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowReport(String Name)
        {


            try
            {






                var a = context.ReturnVoucherReport(Name).ToList();

                if (a.Count() > 0)
                {
                    int? stotal = 0, ustotal = 0, remainingtotoal = 0;

                    foreach (var n in a)
                    {
                        stotal = stotal + int.Parse(n.QTYS);

                        ustotal = ustotal + int.Parse(n.QTYUS);
                        remainingtotoal = remainingtotoal + n.QTYRemaining;
                    }



                    ReportDocument rd = new ReportDocument();
                    rd.Load(Server.MapPath("~/ReturnVoucherReport.rpt"));
                    string printedby = Session["FirstName"].ToString();
                    rd.SetDataSource(a);
                    rd.SetParameterValue("CompanyName", "National Institute Of Electronic");
                    rd.SetParameterValue("AddressPhone", "H-9, Islamabad, Islamabad Capital Territory");
                    rd.SetParameterValue("PrintedBy", printedby);
                    rd.SetParameterValue("QTYDemandTotal", stotal);
                    rd.SetParameterValue("QTYIssuedTotal", ustotal);
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