using System.Collections.Generic;
using DesafioFortes.Application.Interface;
using DesafioFortes.Domain.Entities;
using DesafioFortes.Domain.Interfaces.Services;

namespace DesafioFortes.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService)
            : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IEnumerable<Receita> FiltrarReceitasPorCategoria(int? id)
        {
            return _categoriaService.FiltrarReceitasPorCategoria(id);
        }

        public IEnumerable<Despesa> FiltrarDespesasPorCategoria(int? id)
        {
            return _categoriaService.FiltrarDespesasPorCategoria(id);
        }
    }
}
