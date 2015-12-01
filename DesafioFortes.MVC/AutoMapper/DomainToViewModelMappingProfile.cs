using AutoMapper;
using DesafioFortes.Domain.Entities;
using DesafioFortes.MVC.ViewModels;

namespace DesafioFortes.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Receita, ReceitaViewModel>();
            Mapper.CreateMap<Despesa, DespesaViewModel>();
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}