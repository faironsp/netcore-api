﻿using Api.Domain.Entities;
using FluentValidation;
using System;

namespace Api.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("O campo nome é obrigatório.")
                .NotNull().WithMessage("O campo nome é obrigatório.");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("O campo sobrenome é obrigatório.")
                .NotNull().WithMessage("O campo sobrenome é obrigatório.");

            RuleFor(c => c.Email)
                .EmailAddress().WithMessage("O campo e-mail é inválido.")
                .NotEmpty().WithMessage("O campo e-mail é obrigatório.")
                .NotNull().WithMessage("O campo e-mail é obrigatório.");

            RuleFor(c => c.Birthdate)
                .NotEmpty().WithMessage("O campo data da nascimento é obrigatório.")
                .NotNull().WithMessage("O campo data da nascimento é obrigatório.");

            RuleFor(c => c.Birthdate)
                .NotEmpty().WithMessage("O campo data de nascimento deve ser informado")
                .Must(BirthdateValidator).WithMessage("A data de nascimento não pode ser maior que a data atual");

            RuleFor(c => c.Schooling)
                .NotEmpty().WithMessage("O campo escolaridade é obrigatório.")
                .NotNull().WithMessage("O campo escolaridade é obrigatório.");

            static bool BirthdateValidator(DateTime birthdate)
            {
                return birthdate < DateTime.Now;
            }
        }
    }
}
