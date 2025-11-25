using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do usuário obrigatório!");
            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("Senha do usuário obrigatória!");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email dp usuário obrigatório!");

        }
    }
}