using DocsSearchEngine.Models;
using FluentValidation;

namespace DocsSearchEngine.Validators
{
    public class SearchFilterValidation : AbstractValidator<SearchFilter>
    {
        public SearchFilterValidation()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("Please specify a Content");
            RuleFor(x => x.Metadata).NotEmpty().WithMessage("Please specify a Metadata");
        }
    }
}
