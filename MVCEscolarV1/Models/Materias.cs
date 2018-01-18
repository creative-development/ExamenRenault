using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEscolarV1.Models
{
    public class Materias
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string NomMAteria { get; set; }
        [Required]
        [StringLength(3)]
        public string CreditoMateria { get; set; }

    }
}