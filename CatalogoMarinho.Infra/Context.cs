using Microsoft.EntityFrameworkCore;
using CatalogoMarinho.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMarinho.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04844\\SQLEXPRESS;Initial Catalog=CatalogoMarinho;Integrated Security=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

            modelBuilder.Entity<Animal>().HasOne(p => p.Classe).WithMany(p => p.Animais).HasForeignKey(p => p.IdClasse);
        }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Especie> Especies { get; set; }
    }
}
