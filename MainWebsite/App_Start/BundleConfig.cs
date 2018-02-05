using System.Web.Optimization;

namespace MainWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
#endif
            bundles.Add(new StyleBundle("~/bundles/bootstrapcss", "https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css",
                    "~/Content/font-awesome.css",
                    "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/bundles/fonts", "https://fonts.googleapis.com/css?family=Bree+Serif"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs", "https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.bundle.min.js")
                .Include("~/Scripts/jquery-{version}.js",
                    "~/Scripts/popper.js",
                    "~/Scripts/jquery.validate*",
                    "~/Scripts/jquery.validate.unobtrusive.js",
                    "~/Scripts/modernizr-*",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/customscripts").Include(
                        "~/Scripts/scripts"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/customscripts").Include(
                      "~/Scripts/scripts"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/Site.css"));
        }
    }
}
