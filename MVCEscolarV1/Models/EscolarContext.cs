using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEscolarV1.Models
{
    public class EscolarContext: DbContext
    {
        public EscolarContext() : base("DefaultConnection") { }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Materias> Materias { get; set; }
    }
}