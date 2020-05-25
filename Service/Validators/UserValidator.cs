using Domain.Entities;
using FluentValidation;
using System;

namespace Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto não encontrado.");
                });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("CPF é obrigatório.")
                .NotNull().WithMessage("CPF é obrigatório.");

            RuleFor(c => c.DtAniversario)
                .NotEmpty().WithMessage("Data é obrigatória.")
                .NotNull().WithMessage("Data é obrigatória.");

            RuleFor(c=>c.Nome)
                .NotEmpty().WithMessage("Nome é obrigatória.")
                .NotNull().WithMessage("Nome é obrigatória.");
        }
    }
}
