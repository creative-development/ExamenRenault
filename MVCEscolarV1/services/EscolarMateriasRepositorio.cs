using MVCEscolarV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEscolarV1.services
{
    public class EscolarMateriasRepositorio
    {
        public List<Materias> TodasMaterias()
        {
            using(var db =new EscolarContext())
            {
                return db.Materias.ToList();
            }
        }
        internal void Crear(Materias model)
        {
            using (var db = new EscolarContext())
            {
                db.Materias.Add(model);
                db.SaveChanges();
            }
        }
    }
}