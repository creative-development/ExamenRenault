using MVCEscolarV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEscolarV1.services
{
    public class EscolarAlumnosRepositorio
    {
        public List<Alumnos> TodosAlumnos()
        {
            using (var db = new EscolarContext())
            {
                return db.Alumnos.ToList();
            }
        }

        internal void Crear(Alumnos model)
        {
           using(var db= new EscolarContext())
            {
                db.Alumnos.Add(model);
                db.SaveChanges();
            }
        }
    }
}