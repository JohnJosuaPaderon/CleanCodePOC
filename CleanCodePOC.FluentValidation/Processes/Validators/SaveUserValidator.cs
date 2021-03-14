using FluentValidation;

namespace CleanCodePOC.Processes.Validators
{
    public sealed class SaveUserValidator : AbstractValidator<SaveUser>
    {
        public SaveUserValidator()
        {
            RuleFor(_ => _.Username)
                .NotEmpty().WithMessage("Username is required")
                .MinimumLength(6).WithMessage("Maigsi username mo boy, dapat atleast 6 characters")
                .MaximumLength(10).WithMessage("Username must not be longer than 10 characters");
        }
    }
}
