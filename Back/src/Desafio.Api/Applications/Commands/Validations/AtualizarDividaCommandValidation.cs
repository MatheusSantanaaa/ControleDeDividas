using Desafio.Api.Applications.Commands.Models;

namespace Desafio.Api.Applications.Commands.Validations
{
    public class AtualizarDividaCommandValidation : DividaValidation<AtualizarDividaCommand>
    {
        public AtualizarDividaCommandValidation()
        {
            ValidarId();
            ValidarNumeroDotitulo();
            ValidarCpfDoDevedor();
            ValidarNomeDoDevedor();
            ValidarJuros();
            ValidarMulta();
            ValidarParcelas();
        }
    }
}
