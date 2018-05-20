using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibroBiblia.DAL;
using LibroBiblia.Entidades;
using System.Data.Entity;

namespace LibroBiblia.BLL
{
    public class LibrosBLL
    {
        public static bool Guardar(Libros libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(contexto.libros.Add(libro)!=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Libros libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(libro).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                    paso = true;

                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Libros libro = contexto.libros.Find(id);
                contexto.libros.Remove(libro);

                if(contexto.SaveChanges()>0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }

            catch(Exception)
            {
                throw;
            }
            return paso;
        }
    }
}
