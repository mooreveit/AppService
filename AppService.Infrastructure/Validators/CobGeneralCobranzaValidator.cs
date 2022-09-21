using AppService.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Infrastructure.Validators
{
    public class CobGeneralCobranzaValidator:AbstractValidator<CobGeneralCobranzaDto>
    {

        public CobGeneralCobranzaValidator()
        {

            RuleFor(cobranza => cobranza.MontoTransaccion)
                .NotNull()
                .GreaterThan(0);

            RuleFor(cobranza => cobranza.IdCliente)
               .NotNull()
               .NotEmpty();

            RuleFor(cobranza => cobranza.IdCliente)
              .NotNull()
              .NotEmpty();

            RuleFor(cobranza => cobranza.IdBanco)
              .NotNull()
              .NotEmpty();

            RuleFor(cobranza => cobranza.IdTipoTransaccion)
              .NotNull()
              .NotEmpty();

            RuleFor(cobranza => cobranza.FechaTransaccion)
            .NotNull();



        }

    }
}
