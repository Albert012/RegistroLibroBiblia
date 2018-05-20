using LibroBiblia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace LibroBiblia.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Libros> libros { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
