using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo4_Exercicio.Models;
using Microsoft.EntityFrameworkCore;

namespace Exemplo4_Exercicio.database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Software> Softwares { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Maquina>().ToTable("maquina");
            modelBuilder.Entity<Software>().ToTable("software");
        }
    }
}