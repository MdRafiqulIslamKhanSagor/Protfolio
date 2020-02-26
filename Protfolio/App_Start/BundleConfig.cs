using System.Web;
using System.Web.Optimization;

namespace Protfolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {



            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/ionicons.min.css",
                "~/Content/owl.carousel.min.css",
                "~/Content/magnific-popup.css",
                "~/Content/hover.min.css",
                "~/Content/css/style.css",
                "~/Content/css/responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                "~/Scripts/jquery-3.3.1.js",
                "~/Scripts/jquery-migrate.min.js",
                "~/Scripts/bootstrap.bundle.min.js",
                "~/Scripts/typed.js",
                "~/Scripts/owl.carousel.min.js",
                "~/Scripts/magnific-popup.min.js",
                "~/Scripts/isotope.pkgd.min.js",
                "~/Scripts/contactform.js",
                "~/Scripts/main.js"));


        }
    }
}
