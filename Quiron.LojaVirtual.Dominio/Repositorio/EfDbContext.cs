using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    // dbcontext = classe onde vou colocar todos os meus dbsets
    public class EfDbContext : DbContext
    {
        // dbset =
        public DbSet<Produto> Produtos { get; set; }

        // remover pluralidade no banco (ex: pessoa - pessoas)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // using System.Data.Entity.ModelConfiguration.Conventions;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // classe produto no código = tabela produtos no banco
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
