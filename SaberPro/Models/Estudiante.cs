using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaberPro.Models
{
    public class Estudiante
    {

        public int id { get; set; }
        [Required]

        public string Nombre { get; set; }
        

        public string Apellidos { get; set; }
        [Required]

        public string Estado { get; set; }
        [Required]

        public string Nivel { get; set; }
        [Required]

        public int id_Ciudad { get; set; }
        

        public int Codigo_ProgAcademico { get; set; }
        

        /*
        //ForeignKey con el ID de usuario
        [ForeignKey("id_Usuario_fk")]
        public int Usuario_id { get; set; }
        public Usuario id_Usuario_fk { get; set; }
        */
    }
}