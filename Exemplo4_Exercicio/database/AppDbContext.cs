using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Importa o namespace do Entity Framework
using Microsoft.EntityFrameworkCore.Metadata.Internal; // Importa o namespace do Entity Framework


namespace Exemplo4_Exercicio.database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Vamos criar um DbSet para cada tabela do banco de dados
        public DbSet<Model.Usuarios> Usuarios {get; set;}
        public DbSet<Model.Maquina> Maquina {get; set;}
        public DbSet<Model.Software> Software {get; set;}
    }
}