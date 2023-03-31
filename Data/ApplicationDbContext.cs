using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using prueba_connection_postgresql.Models;

namespace prueba_connection_postgresql.Data
{
    public class ApplicationDbContext : DbContext
    {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
      {
      }

      public DbSet<Persona> Personas { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
          // Configurar la relación entre entidades, definir restricciones de clave foránea, etc.
      }
    }
}