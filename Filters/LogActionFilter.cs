using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;

namespace MiTiendaMVC.Filters
{
    // Heredamos de ActionFilterAttribute para poder sobrescribir sus métodos
    public class LogActionFilter : ActionFilterAttribute
    {
        // Este método se ejecuta antes de que la acción del controlador inicie
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string accion = filterContext.ActionDescriptor.ActionName;
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Imprime en la ventana de "Salida" (Output) de Visual Studio
            Debug.WriteLine($"[LOG] Acción: {accion} | Ejecutada el: {fechaHora}");

            base.OnActionExecuting(filterContext);
        }
    }
}