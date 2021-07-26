using System.Web;
using System.Web.Optimization;

namespace CarritoCompras
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/slider").Include(
                "~/Scripts/slider.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Style.css"));
        }
    }
}
