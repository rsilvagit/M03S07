using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FichaCadastroAPI.Model
{
    public class FichaCadastroContextDB : DbContext
    {
       public FichaCadastroContextDB(DbContextOptions options) : base(options)
       {
       }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalheModel>().HasOne(h => h.Ficha)
                                               .WithMany(w => w.DetalheModels); /* relacionamento 1(ficha)xn(detalhes)*/
            modelBuilder.Entity<DetalheModel>().Property(p => p.DataCadastro)
                                               .HasDefaultValueSql("GETDATE()"); /*criando valor default para DataCadastro que será obtida pela dta de inserção no db*/
            modelBuilder.Entity<FichaModel>().Property(p => p.DataCadastro)
                                             .HasDefaultValueSql("GETDATE()");
            base.OnModelCreating(modelBuilder);
        }

    }
}