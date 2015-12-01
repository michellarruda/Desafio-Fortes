using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DesafioFortes.Domain.Entities;

namespace DesafioFortes.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        IEnumerable<Receita> FiltrarReceitasPorCategoria(int? id);
        IEnumerable<Despesa> FiltrarDespesasPorCategoria(int? id);
    }
}
