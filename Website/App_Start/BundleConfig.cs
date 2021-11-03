using System.Web;
using System.Web.Optimization;

namespace Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.9.1.min.js",
                        "~/Scripts/jquery.ba-cond.min",
                        "~/Scripts/jquery.slitslider.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.6.2-respond-1.1.0.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/otherScripts").Include(
                        "~/Scripts/main.js",
                        "~/Scripts/twitter-bootstrap-hover-dropdown.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-responsive.min.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/main.css",
                      "~/Content/sl-slide.css"));
        }
    }
}
