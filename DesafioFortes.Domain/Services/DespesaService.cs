using DesafioFortes.Domain.Entities;
using DesafioFortes.Domain.Interfaces.Repositories;
using DesafioFortes.Domain.Interfaces.Services;

namespace DesafioFortes.Domain.Services
{
    public class DespesaService : ServiceBase<Despesa>, IDespesaService
    {
        private readonly IDespesaRepository _despesaRepository;

        public DespesaService(IDespesaRepository despesaRepository)
            : base(despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }
    }
}
