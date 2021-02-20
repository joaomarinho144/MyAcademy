using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAcademy.Business.Models.Validations
{
    public class ExercicioValidation : AbstractValidator<Exercicio>
    {
        public ExercicioValidation()
        {
            RuleFor(p => p.TreinoId)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio");

            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Series)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Repeticoes)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.RPE)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Descanso)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Tecnica)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Observacoes)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser vazio")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
