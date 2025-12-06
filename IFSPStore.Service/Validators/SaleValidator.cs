using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator()
        {
            RuleFor(sale => sale.Customer)
                .NotNull().WithMessage("Cliente é obrigatório.");
            RuleFor(sale => sale.SaleItens)
                .NotNull().WithMessage("Venda deve conter itens.")
                .Must(items => items != null && items.Count > 0)
                .WithMessage("Venda deve conter pelo menos um item.");
        }

    }

    public class SaleItemValidator : AbstractValidator<SaleItem>
    {
        public SaleItemValidator()
        {
            RuleFor(item => item.Product)
                .NotNull().WithMessage("Produto é obrigatório.");
            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("Quantidade deve ser maior que zero.");
            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("Preço unitário deve ser maior que zero.");
            RuleFor(item => item.TotalPrice)
                .GreaterThan(0).WithMessage("Preço total deve ser maior que zero.");
        }
    }
}