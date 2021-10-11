using EjercicioMVC.Datos;
using EjercicioMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioMVC.Controllers
{
    public class VentaController : Controller
    {
        VentasAdmin adminVenta = new VentasAdmin();
        // GET: Venta
        public ActionResult Index()
        {
            return View(adminVenta.Consultar());
        }
        public ActionResult Detalle(int id)
        {
            return View(adminVenta.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(VENTA modelo)
        {
            adminVenta.Guardar(modelo);
            return View("Crear", modelo);
        }
        public ActionResult Editar(int id)
        {
            return View(adminVenta.Consultar(id));
        }
        public ActionResult Modificar(VENTA modelo)
        {
            adminVenta.Modificar(modelo);
            return View("Editar", modelo);
        }
        public ActionResult Eliminar(int id)
        {
            VENTA modelo = adminVenta.Consultar(id);
            adminVenta.Eliminar(modelo);
            return View("Index", adminVenta.Consultar());
        }

    }
}