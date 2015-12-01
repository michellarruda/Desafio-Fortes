using DesafioFortes.Application.Interface;
using DesafioFortes.Domain.Entities;
using DesafioFortes.Domain.Interfaces.Services;

namespace DesafioFortes.Application
{
    public class ReceitaAppService : AppServiceBase<Receita>, IReceitaAppService
    {
        private readonly IReceitaService _receitaService;

        public ReceitaAppService(IReceitaService receitaService)
            : base(receitaService)
        {
            _receitaService = receitaService;
        }
    }
}
