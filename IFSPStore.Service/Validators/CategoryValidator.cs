using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validations
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome da categoria obrigatório!");

        }
    }
}