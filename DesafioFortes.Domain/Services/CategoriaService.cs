using System.Collections.Generic;
using DesafioFortes.Domain.Entities;
using DesafioFortes.Domain.Interfaces.Repositories;
using DesafioFortes.Domain.Interfaces.Services;

namespace DesafioFortes.Domain.Services
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
            : base(categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IEnumerable<Receita> FiltrarReceitasPorCategoria(int? id)
        {
            return _categoriaRepository.FiltrarReceitasPorCategoria(id);
        }

        public IEnumerable<Despesa> FiltrarDespesasPorCategoria(int? id)
        {
            return _categoriaRepository.FiltrarDespesasPorCategoria(id);
        }
    }
}
