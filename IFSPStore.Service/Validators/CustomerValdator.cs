using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("O nome do cliente é obrigatório!");
            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("O endereço do cliente é obrigatório!");
            RuleFor(c => c.Document)
                .NotEmpty().WithMessage("O documento do cliente é obrigatório!")
                .MaximumLength(20).WithMessage("O documento do cliente não deve ultrapassar 20 caracteres.");
            RuleFor(c => c.District)
                .NotEmpty().WithMessage("O bairro do cliente é obrigatório.")
                .MaximumLength(100).WithMessage("O bairro do cliente não deve ultrapassar 100 caracteres.");
            RuleFor(c => c.City)
                .NotNull().WithMessage("A cidade do cliente é obrigatória.");
        }
    }
}