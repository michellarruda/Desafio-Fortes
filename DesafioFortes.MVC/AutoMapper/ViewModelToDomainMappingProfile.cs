using AutoMapper;
using DesafioFortes.Domain.Entities;
using DesafioFortes.MVC.ViewModels;

namespace DesafioFortes.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ReceitaViewModel, Receita>();
            Mapper.CreateMap<DespesaViewModel, Despesa>();
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
        }
    }
}