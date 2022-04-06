using System.Web;
using System.Web.Optimization;

namespace InventoryManagementSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/Logincss").Include(
                "~/Content/assets/assets/css/googleapis.css",
                "~/Content/global_assets/css/icons/icomoon/styles.min.css",
                "~/Content/assets/assets/css/bootstrap.min.css",
                "~/Content/assets/assets/css/bootstrap_limitless.min.css",
                "~/Content/assets/assets/css/layout.min.css",
                "~/Content/assets/assets/css/components.min.css"
        ));
            bundles.Add(new ScriptBundle("~/bundles/LoginScripts").Include(
           "~/Content/global_assets/js/main/jquery.min.js",
         "~/Content/global_assets/js/plugins/loaders/blockui.min.js"
         ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                 "~/Content/assets/assets/css/googleapis.css",
             "~/Content/global_assets/css/icons/icomoon/styles.min.css",
             "~/Content/global_assets/css/icons/fontawesome/styles.min.css",
              "~/Content/assets/assets/css/bootstrap.min.css",
               "~/Content/assets/assets/css/bootstrap_limitless.css",
                    "~/Content/assets/assets/css/layout.css",
               "~/Content/assets/assets/css/components.min.css",
                    "~/Content/assets/assets/css/colors.min.css",
                   "~/Content/assets/assets/css/NCCustom.css",


                       "~/Content/assets/assets/css/sweetalert.css"

             ));
            bundles.Add(new StyleBundle("~/bundles/ExtraCss").Include(
        "~/Content/global_assets/css/icons/material/styles.min.css"

        ));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
             "~/Content/global_assets/js/main/jquery.min.js",
             "~/Content/global_assets/js/main/bootstrap.bundle.min.js",
              "~/Content/global_assets/js/plugins/loaders/blockui.min.js",
              "~/Content/assets/assets/js/app.js",
             "~/Content/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.js",
             "~/Content/taginput/tagInput.js"


             ));






            bundles.Add(new ScriptBundle("~/bundles/DataTableScripts").Include(
                "~/Content/global_assets/js/plugins/tables/datatables/datatables.min.js",
                "~/Content/global_assets/js/demo_pages/datatables_advanced.js",
                "~/Content/global_assets/js/plugins/tables/datatables/extensions/buttons.min.js",
                "~/Content/global_assets/js/plugins/tables/datatables/extensions/select.min.js",
                "~/Content/global_assets/js/plugins/tables/datatables/extensions/jszip/jszip.min.js",
                "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/pdfmake.min.js",
                "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/vfs_fonts.min.js",
                "~/Content/global_assets/js/demo_pages/datatables_extension_buttons_html5.js",
                "~/Content/global_assets/js/demo_pages/datatables_extension_buttons_print.js"
             ));
            bundles.Add(new ScriptBundle("~/bundles/Select2").Include(
            "~/Content/global_assets/js/plugins/forms/selects/select2.min.js",
              "~/Content/global_assets/js/plugins/forms/Cselects/bootstrap_multiselect.js"
            ));


            bundles.Add(new ScriptBundle("~/bundles/SweetAlertsJs").Include(
"~/Content/assets/assets/js/sweetalert.min.js"

));


            bundles.Add(new ScriptBundle("~/bundles/ERPScripts").Include(
                       "~/Content/global_assets/js/plugins/forms/styling/uniform.min.js",

            "~/Content/global_assets/js/plugins/visualization/d3/d3.min.js",
            "~/Content/global_assets/js/plugins/visualization/d3/d3_tooltip.js",
            "~/Content/global_assets/js/plugins/forms/styling/switchery.min.js",
            "~/Content/global_assets/js/plugins/ui/moment/moment.min.js",
            "~/Content/global_assets/js/plugins/pickers/daterangepicker.js",
            "~/Content/global_assets/js/plugins/ui/fullcalendar/core/main.min.js",
            "~/Content/global_assets/js/plugins/ui/fullcalendar/daygrid/main.min.js",
            "~/Content/global_assets/js/plugins/ui/fullcalendar/timegrid/main.min.js",
            "~/Content/global_assets/js/plugins/ui/fullcalendar/interaction/main.min.js",
            "~/Content/global_assets/js/plugins/visualization/echarts/echarts.min.js",

            "~/Content/global_assets/js/demo_pages/timelines.js"
));
            bundles.Add(new ScriptBundle("~/bundles/Validation").Include(

                "~/Script/jquery.validate.min.js",
                "~/Script/jquery.validate.unobtrusive.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/DateScripts").Include(
                "~/Content/global_assets/js/plugins/ui/moment/moment.min.js",
                "~/Content/global_assets/js/plugins/pickers/daterangepicker.js",
                "~/Content/global_assets/js/plugins/pickers/anytime.min.js",
                "~/Content/global_assets/js/plugins/pickers/pickadate/picker.js",
                "~/Content/global_assets/js/plugins/pickers/pickadate/picker.date.js",
                "~/Content/global_assets/js/plugins/pickers/pickadate/picker.time.js",
                "~/Content/global_assets/js/plugins/pickers/pickadate/legacy.jss",
                "~/Content/global_assets/js/plugins/notifications/jgrowl.min.js",
                 "~/Content/global_assets/js/demo_pages/picker_date.js",
                 "~/Content/TimePickerHourMinutes.js"
         ));
            bundles.Add(new ScriptBundle("~/bundles/EChartsScripts").Include(
                 "~/Content/global_assets/js/plugins/visualization/d3/d3.min.js",
               "~/Content/global_assets/js/plugins/visualization/d3/d3_tooltip.js",
              "~/Content/global_assets/js/plugins/visualization/echarts/echarts.min.js",
              "~/Content/global_assets/js/demo_pages/charts/echarts/candlesticks_others.js",
              "~/Content/global_assets/js/demo_pages/charts/echarts/columns_waterfalls.js",
              "~/Content/global_assets/js/plugins/visualization/c3/c3.min.js",
              "~/Content/global_assets/js/demo_pages/charts/c3/c3_axis.js"
              ));



        }
    }
}
