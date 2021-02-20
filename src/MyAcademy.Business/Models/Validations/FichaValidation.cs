using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAcademy.Business.Models.Validations
{
    public class FichaValidation : AbstractValidator<Ficha>
    {
        public FichaValidation()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Observacoes)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
