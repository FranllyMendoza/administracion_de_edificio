using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using administracion_de_edificio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace administracion_de_edificio.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Facturar> factura { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\Gestordeadministraciondeedificio.db");
        }
    }
}
