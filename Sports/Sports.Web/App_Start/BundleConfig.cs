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
                      "~/Scripts/Vendor/bootbox.min.js",
                      "~/Scripts/Vendor/ngBootbox.js",
                      "~/Scripts/Vendor/Chart.min.js",
                      "~/Scripts/Vendor/angular-chart.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/appScript").Include(
                "~/Scripts/App/main.js"
            ));

            bundles.Add(new StyleBundle("~/Content/vendorCSS").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/linearicons.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/animate.css"));
            bundles.Add(new StyleBundle("~/Content/mainCSS").Include(
                "~/Content/normalize.css",
                "~/Content/site.css",
                "~/Content/responsive.css"));
        }
    }
}
