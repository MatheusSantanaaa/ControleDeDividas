using Desafio.Api.Applications.Dtos;

namespace Desafio.Api.Applications.Queries
{
    public interface IDividaQuerie
    {
        Task<DividaDto> ObterPorId(Guid Id);
        Task<ICollection<DividaDto>> ObterListagem();
    }
}
