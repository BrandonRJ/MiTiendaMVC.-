using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MiTiendaMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Creamos un bundle para nuestros estilos CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css"));

            // Habilitar la optimización (minificación)
            BundleTable.EnableOptimizations = true;
        }
    }
}