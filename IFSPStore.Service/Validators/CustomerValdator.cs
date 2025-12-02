using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CostumerValidator : AbstractValidator<Costumer>
    {
        public CostumerValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .MaximumLength(100).WithMessage("Nome não pode ultrapassar 100 caracteres.");
            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Endereço é obrigatório.")
                .MaximumLength(100).WithMessage("Endereço não pode ultrapassar 100 caracteres.");
            RuleFor(c => c.Document)
                .NotEmpty().WithMessage("Documento é obrigatório.")
                .MaximumLength(50).WithMessage("Documento não pode ultrapassar 50 caracteres.");
            RuleFor(c => c.District)
                .NotEmpty().WithMessage("Distrito é obrigatório.")
                .MaximumLength(50).WithMessage("Distrito não pode ultrapassar 50 caracteres.");
            RuleFor(c => c.City)
                .NotNull().WithMessage("Cidade é obrigatório.");
        }

    }
}