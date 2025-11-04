using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validations
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator()
        {
            RuleFor(sale => sale.SaleDate)
                .NotEmpty().WithMessage("Data da venda obrigatória!")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data da venda não pode ser no futuro.");
            RuleFor(sale => sale.SaleTotal)
                .GreaterThan(0).WithMessage("Total deve ser maior que zero!");
            RuleFor(sale => sale.Salesman)
                .NotNull().WithMessage("Vendedor obrigatório!");
            RuleFor(sale => sale.Customer)
                .NotNull().WithMessage("Cliente obrigatório!");
            RuleFor(sale => sale.SaleItens)
                .NotEmpty().WithMessage("Venda deve conter pelo menos um item!");

        }

        private class SaleItemValidator : AbstractValidator<SaleItem>
        {
            public SaleItemValidator()
            {
                RuleFor(item => item.Product)
                    .NotNull().WithMessage("Item da venda obrigatório!");
                RuleFor(item => item.Quantity)
                    .GreaterThan(0).WithMessage("Quantidade do item da venda deve ser maior que zero!");
                RuleFor(item => item.UnitPrice)
                    .GreaterThan(0).WithMessage("Preço unitário do item da venda deve ser maior que zero!");
                RuleFor(item => item.TotalPrice)
                    .Equal(item => item.Quantity * item.UnitPrice).WithMessage("Preço total do item da venda deve ser igual à quantidade multiplicada pelo preço unitário!");
            }
        }
    }
}