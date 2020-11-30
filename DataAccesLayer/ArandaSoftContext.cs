using Common;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccesLayer
{
    public class ArandaSoftContext : DbContext
    {
        public ArandaSoftContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Acciones> Acciones { get; set; }
        public DbSet<RolAcciones> RolAcciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Roles>().HasData(new Roles
            {
                RolId = 1,
                Nombre = "Visitante",
                Estado = "A",
                FechaCreacion = DateTime.Now,
            }, new Roles
            {
                RolId = 2,
                Nombre = "Asistente",
                Estado = "A",
                FechaCreacion = DateTime.Now,
            }, new Roles
            {
                RolId = 3,
                Nombre = "Editor",
                Estado = "A",
                FechaCreacion = DateTime.Now,
            }, new Roles
            {
                RolId = 4,
                Nombre = "Administrador",
                Estado = "A",
                FechaCreacion = DateTime.Now,
            });
            
            _ = modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                Id = 1,
                Usuario= "admon",
                Password= Security.GetSHA256("123"),
                Nombres = "Tania Lized",
                Apellidos = "Forero",
                Direccion = "Calle 120 # 45 -67",
                Telefono = "7563000",
                FechaNacimiento = DateTime.Now.AddMonths(-240),
                Email= "tania.forero@arandasoft.com",
                Edad = 20,
                RolesRolId = 4,
                Estado = "A",
                FechaCreacion = DateTime.Now,
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
