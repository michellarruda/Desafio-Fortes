using System.Collections.Generic;
using DesafioFortes.Domain.Entities;

namespace DesafioFortes.Domain.Interfaces.Services
{
    public interface ICategoriaService : IServiceBase<Categoria>
    {
        IEnumerable<Receita> FiltrarReceitasPorCategoria(int? id);
        IEnumerable<Despesa> FiltrarDespesasPorCategoria(int? id);
    }
}
