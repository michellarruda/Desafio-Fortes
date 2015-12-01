using System.Data.Entity.ModelConfiguration;
using DesafioFortes.Domain.Entities;

namespace DesafioFortes.Infra.Data.EntityConfig
{
    public class ReceitaConfiguration : EntityTypeConfiguration<Receita>
    {
        public ReceitaConfiguration()
        {
            HasKey(p => p.ReceitaId);

            Property(c => c.Valor)
                .IsRequired();

            Property(c => c.Data)
                .IsRequired();

            Property(c => c.Observacao)
                .HasMaxLength(150);

            HasRequired(c => c.Categoria)
                 .WithMany()
                 .HasForeignKey(c => c.CategoriaId);
        }
    }
}
