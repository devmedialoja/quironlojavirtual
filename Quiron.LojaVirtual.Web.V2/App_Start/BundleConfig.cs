using System.Web;
using System.Web.Optimization;

namespace Quiron.LojaVirtual.Web.V2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/*.css"));

            bundles.Add(new ScriptBundle("~/js").Include(
                     "~/js/jquery.js",
                      "~/js/bootstrap.js"));


            // <!-- SmartMenu http://www.smartmenus.org/ -->
            bundles.Add(new StyleBundle("~/Content/startmenu").Include(
                 "~/Content/sm-core-css.css",
                  "~/Content/sm-simple/sm-simple.css"
             ));

            bundles.Add(new ScriptBundle("~/Scripts/startmenu").Include(
                    "~/Scripts/jquery.smartmenus.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jsprojetos").Include(
                    "~/Scripts/menu.js"));



            BundleTable.EnableOptimizations = false;
        }
    }
}
