using Desafio.Api.Applications.Commands.Models;

namespace Desafio.Api.Applications.Commands.Validations
{
    public class RemoverDividaCommandValidation : DividaValidation<RemoverDividaCommand>
    {
        public RemoverDividaCommandValidation()
        {
            ValidarId();
        }
    }
}
