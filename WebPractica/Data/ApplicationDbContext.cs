using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPractica.Models;

namespace WebPractica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Constructor se crea con ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }

        //Agregamos todos los modelos que luego seran tablas
        public DbSet<Registro> Registros { get; set;  }

        public DbSet<AppUsuario> AppUsuario { get; set; }
    }
}
