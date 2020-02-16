using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaberPro.Models
{
    public class Usuario
    {
        public int id { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]
        [StringLength(20)]

        public string Password { get; set; }
        [Required]

        public string Rol { get; set; }
        [Required]

        //ForeignKey
        public List<Estudiante> estudiantes { get; set; }
    }
}