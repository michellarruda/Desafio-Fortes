using DesafioFortes.Domain.Entities;
using DesafioFortes.Domain.Interfaces.Repositories;
using DesafioFortes.Domain.Interfaces.Services;

namespace DesafioFortes.Domain.Services
{
    public class ReceitaService : ServiceBase<Receita>, IReceitaService
    {
        private readonly IReceitaRepository _despesaRepository;

        public ReceitaService(IReceitaRepository despesaRepository)
            : base(despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }
    }
}
