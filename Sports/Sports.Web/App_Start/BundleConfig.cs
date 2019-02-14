using System.Web;
using System.Web.Optimization;

namespace Sports.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/Vendor/owl.carousel.js",
                      "~/Scripts/Vendor/contact-form.js",
                      "~/Scripts/Vendor/ajaxchimp.js",
                      "~/Scripts/Vendor/scrollUp.min.js",
                      "~/Scripts/Vendor/magnific-popup.min.js",
                      "~/Scripts/Vendor/wow.min.js",
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-animate.js",
                      "~/Scripts/angular-aria.js",
                      "~/Scripts/angular-messages.js",
                      "~/Scripts/angular-resource.js",
                      "~/Scripts/angular-resource.js",
                      "~/Scripts/Vendor/angular-material.min.js",
                      "~/Scripts/Vendor/angular-block-ui.js",
                      "~/Scripts/Vendor/angular-strap.js",
                      "~/Scripts/Vendor/angular-strap.tpl.js",
                      "~/Scripts/Vendor/bootbox.min.js", 
                      "~/Scripts/Vendor/ngBootbox.js",
                      "~/Scripts/Vendor/Chart.min.js",
                      "~/Scripts/Vendor/angular-chart.js",
                      "~/Scripts/Vendor/multiple-select.js",
                      "~/Scripts/Vendor/autocomplete.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/appScript").Include(
                "~/Scripts/App/*.js",
                "~/Scripts/App/Controller/*.js",
                "~/Scripts/App/Directive/*.js",
                "~/Scripts/App/services/*.js"
            ));
//            bundles.Add(new ScriptBundle("~/bundles/scripts").IncludeDirectory(
//                "~/Scripts/", "*.js", true));



            bundles.Add(new StyleBundle("~/Content/vendorCSS").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/angular-block-ui.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/linearicons.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/angular-material.min.css",
                      "~/Content/autocomplete.css",
                      "~/Content/multiple-select.css",
                      "~/Content/animate.css"));

            bundles.Add(new StyleBundle("~/Content/mainCSS").Include(
                "~/Content/normalize.css",
                "~/Content/site.css",
                "~/Content/responsive.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
