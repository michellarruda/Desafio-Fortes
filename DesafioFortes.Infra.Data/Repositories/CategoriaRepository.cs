using System.Collections.Generic;
using System.Linq;
using DesafioFortes.Domain.Entities;
using DesafioFortes.Domain.Interfaces.Repositories;

namespace DesafioFortes.Infra.Data.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public IEnumerable<Receita> FiltrarReceitasPorCategoria(int? id)
        {
            return Db.Receitas.Where(x => x.CategoriaId == id);
        }

        public IEnumerable<Despesa> FiltrarDespesasPorCategoria(int? id)
        {
            return Db.Despesas.Where(x => x.CategoriaId == id);
        }
    }
}
