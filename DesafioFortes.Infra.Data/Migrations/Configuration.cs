using DesafioFortes.Domain.Entities;

namespace DesafioFortes.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.DesafioFortesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.DesafioFortesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Categorias.Add(new Categoria() { CategoriaId = 1, Nome = "Lazer" });
            context.Categorias.Add(new Categoria() { CategoriaId = 2, Nome = "Alimentação" });
            context.Categorias.Add(new Categoria() { CategoriaId = 3, Nome = "Shopping" });
            context.Categorias.Add(new Categoria() { CategoriaId = 4, Nome = "Viagens" });
            context.Categorias.Add(new Categoria() { CategoriaId = 5, Nome = "Carro" });
            context.Categorias.Add(new Categoria() { CategoriaId = 6, Nome = "Saúde" });
        }
    }
}
