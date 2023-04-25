using AutoMapper;
using Desafio.Api.Applications.Commands.Models;
using Desafio.Api.Applications.Dtos;
using Desafio.Domain.Models;

namespace Desafio.Api.Applications.AutoMapper
{
    public class MappingHelperProfile : Profile
    {
        public MappingHelperProfile()
        {
            #region ViewModels e Models
            CreateMap<RegistrarDividaDto, Divida>().ReverseMap();
            CreateMap<AtualizarDividaDto, Divida>().ReverseMap();
            CreateMap<DividaDto, Divida>().ReverseMap();
            CreateMap<ParcelasDto, Parcela>().ReverseMap();
            #endregion

            #region ViewModels e Commands
            CreateMap<RegistrarDividaDto, RegistrarDividaCommand>().ReverseMap();
            CreateMap<AtualizarDividaDto, AtualizarDividaCommand>().ReverseMap();
            #endregion
        }
    }
}
