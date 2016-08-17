using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BilgeKolejProject.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                "~/Scripts/jquery-1.8.3.min.js",
                "~/Scripts/breakpoints.js",
                "~/Scripts/jquery-ui-1.10.1.custom.min.js",
                "~/Scripts/jquery.slimscroll.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.blockui.js",
                "~/Scripts/jquery.cookie.js",
                "~/Scripts/jquery.flot.js",
                "~/Scripts/jquery.flot.resize.js",
                "~/Scripts/jquery.gritter.js",
                "~/Scripts/jquery.uniform.min.js",
                "~/Scripts/jquery.pulsate.min.js",
                "~/Scripts/chosen.jquery.min.js",
                "~/Scripts/app.js",
                "~/Scripts/jquery.dataTables.js",
                "~/Scripts/DT_bootstrap.js"
                ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/metro.css",
                "~/Content/css/bootstrap-responsive.min.css",
                "~/Content/css/font-awesome.css",
                "~/Content/css/style.css",
                "~/Content/css/style_responsive.css",
                "~/Content/css/style_default.css",
                "~/Content/css/jquery.gritter.css",
                "~/Content/css/chosen.css",
                "~/Content/css/uniform.default.css",
                "~/Content/css/DT_bootstrap.css"
                ));
        }
    }
}
