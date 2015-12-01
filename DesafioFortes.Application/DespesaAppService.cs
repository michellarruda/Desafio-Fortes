using DesafioFortes.Application.Interface;
using DesafioFortes.Domain.Entities;
using DesafioFortes.Domain.Interfaces.Services;

namespace DesafioFortes.Application
{
    public class DespesaAppService : AppServiceBase<Despesa>, IDespesaAppService
    {
        private readonly IDespesaService _despesaService;

        public DespesaAppService(IDespesaService despesaService)
            : base(despesaService)
        {
            _despesaService = despesaService;
        }
    }
}
