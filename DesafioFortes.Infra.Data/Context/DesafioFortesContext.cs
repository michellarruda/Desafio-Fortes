using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DesafioFortes.Domain.Entities;
using DesafioFortes.Infra.Data.EntityConfig;

namespace DesafioFortes.Infra.Data.Context
{
    public class DesafioFortesContext : DbContext
    {
        public DesafioFortesContext()
            : base("DesafioFortesContexto")
        {

        }

        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new DespesaConfiguration());
            modelBuilder.Configurations.Add(new ReceitaConfiguration());
        }
    }
}
