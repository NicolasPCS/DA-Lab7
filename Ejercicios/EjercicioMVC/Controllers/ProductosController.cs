using EjercicioMVC.Datos;
using EjercicioMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioMVC.Controllers
{
    public class ProductosController : Controller
    {
        ProductosAdmin adminProductos = new ProductosAdmin();
        // GET: Productos
        public ActionResult Index()
        {
            return View(adminProductos.Consultar());
        }
        public ActionResult Detalle(int id)
        {
            return View(adminProductos.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(PRODUCTOS modelo)
        {
            adminProductos.Guardar(modelo);
            return View("Crear", modelo);
        }
        public ActionResult Editar(int id)
        {
            return View(adminProductos.Consultar(id));
        }
        public ActionResult Modificar(PRODUCTOS modelo)
        {
            adminProductos.Modificar(modelo);
            return View("Editar", modelo);
        }
        public ActionResult Eliminar(int id)
        {
            PRODUCTOS modelo = adminProductos.Consultar(id);
            adminProductos.Eliminar(modelo);
            return View("Index", adminProductos.Consultar());
        }

    }
}