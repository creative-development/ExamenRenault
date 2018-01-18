using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEscolarV1.Models
{
    public class Alumnos
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string AluNom { get; set; }
        [Required]
        [StringLength(50)]
        public string AluApePat { get; set; }
        [Required]
        [StringLength(50)]
        public string AluApeMat { get; set; }
        [Required]
        [StringLength(50)]
        public string AluMail { get; set; }
        [Required]
        [StringLength(50)]
        public string AluTel { get; set; }
        [Required]
        [StringLength(4)]
        public string status { get; set; }
    }
}