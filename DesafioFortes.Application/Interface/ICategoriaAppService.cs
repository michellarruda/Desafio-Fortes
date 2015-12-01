using System.Collections.Generic;
using DesafioFortes.Domain.Entities;

namespace DesafioFortes.Application.Interface
{
    public interface ICategoriaAppService : IAppServiceBase<Categoria>
    {
        IEnumerable<Receita> FiltrarReceitasPorCategoria(int? id);
        IEnumerable<Despesa> FiltrarDespesasPorCategoria(int? id);
    }
}
