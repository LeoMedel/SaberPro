using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace SaberPro.Models
{
    public class ClassContext : DbContext
    {

        public ClassContext() : base("saberProConnection")
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Estudiante> Estudiante { get; set; }

    }
}