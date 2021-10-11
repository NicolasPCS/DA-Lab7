using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EjercicioMVC.Models;

namespace EjercicioMVC.Datos
{
    public class VentasAdmin
    {
        public IEnumerable<VENTA> Consultar()
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.VENTA.AsNoTracking().ToList();
            }
        }
        public VENTA Consultar(int id)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.VENTA.AsNoTracking().FirstOrDefault(c =>
                c.codventa == id);
            }
        }
        public void Guardar(VENTA modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.VENTA.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(VENTA modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(VENTA modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}