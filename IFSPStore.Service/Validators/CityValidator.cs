using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validations
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome da cidade obrigatório!");
            RuleFor(c => c.State)
                .NotEmpty().WithMessage("Nome do estado obrigatório!")
                .Length(2).WithMessage("Estado deve ter exatamente 2 caracteres!");
        }
    }
}