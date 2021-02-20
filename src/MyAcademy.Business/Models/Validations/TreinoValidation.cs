using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAcademy.Business.Models.Validations
{
    public class TreinoValidation : AbstractValidator<Treino>
    {
        public TreinoValidation()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.DataCadastro)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio");

            RuleFor(p => p.TempoMedioDuracao)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio");

            RuleFor(p => p.FichaId)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio");

            RuleFor(p => p.Observacoes)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
