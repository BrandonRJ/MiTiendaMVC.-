using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiTiendaMVC.Filters; 

namespace MiTiendaMVC.Controllers
{
    [LogActionFilter] //  Aplicamos el filtro a todo el controlador
    public class ProductosController : Controller
    {
        public ActionResult Index()
        {
            // 1. ViewData (Usa un diccionario de objetos)
            ViewData["TituloPagina"] = "Mi Agenda de Tareas Razor";

            // 2. ViewBag (Usa propiedades dinámicas)
            ViewBag.MensajeInformativo = "Datos cargados desde el controlador.";

            // 3. TempData (Ideal para mensajes temporales)
            TempData["EstadoConexion"] = "Conexión Exitosa";

            // Lista de productos para el bucle Razor
            List<string> listaTareas = new List<string>
            {
                "Revisar servidor",
                "Actualizar base de datos",
                "Limpiar caché"
            };

            return View(listaTareas);
        }
    }
}