using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do produto obrigatório!");
            RuleFor(c => c.Price)
                .NotEmpty().WithMessage("Preço do produto obrigatório!")
                .GreaterThan(0).WithMessage("Preço deve ser maior que 0!");
            RuleFor(c => c.Quantity)
                .GreaterThanOrEqualTo(0).WithMessage("Quantidade deve ser maior que 0!");

        }
    }
}