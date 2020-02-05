using Microsoft.EntityFrameworkCore;
using PrimerParcial2.DAL;
using PrimerParcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial2.Controllers
{
    public class ControllersArticulos
    {
        public bool Guardar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Articulos.Add(articulos);
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Articulos.Find(id);
                contexto.Entry(eliminar).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }



            return paso;
        }

        public Articulos Buscar(int id)
        {
            
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();

            try
            {
                articulos = contexto.Articulos.Find(id);

            }
            catch (Exception)
            {

                throw;
            }



            return articulos;
        }

    }
}
