﻿using Desafio.Api.Applications.Commands.Validations;
using Desafio.Domain.Models;

namespace Desafio.Api.Applications.Commands.Models
{
    public class RegistrarDividaCommand : DividaCommand
    {
        public RegistrarDividaCommand(string numeroDoTitulo, string nomeDoDevedor, string cpfDoDevedor, decimal juros, decimal multa, ICollection<Parcela> parcelas)
        {
            NumeroDoTitulo = numeroDoTitulo;
            NomeDoDevedor = nomeDoDevedor;
            CpfDoDevedor = cpfDoDevedor;
            Juros = juros;
            Multa = multa;
            Parcelas = parcelas;
        }

        public override bool EhValido()
        {
            ValidationResult = new RegistrarDividaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
