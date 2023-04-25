using Desafio.Api.Applications.Commands.Models;

namespace Desafio.Api.Applications.Commands.Validations
{
    public class RegistrarDividaCommandValidation : DividaValidation<RegistrarDividaCommand>
    {
        public RegistrarDividaCommandValidation()
        {
            ValidarNumeroDotitulo();
            ValidarCpfDoDevedor();
            ValidarNomeDoDevedor();
            ValidarJuros();
            ValidarMulta();
            ValidarParcelas();
        }
    }
}
