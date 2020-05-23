using FluentValidation.Web.Services;

namespace FluentValidation.Web.Models
{
    public class AddEditPaymentModel
    {
        public decimal Amount { get; set; }
    }

    public class AddEditPaymentModelValidator : AbstractValidator<AddEditPaymentModel>
    {
        public AddEditPaymentModelValidator(IPaymentValidateService service)
        {
            RuleFor(p => p.Amount)
                .NotEmpty()
                .GreaterThan(0)
                .Custom((amount, validationContext) =>
                {
                    var isInvalid = service.DoesAmountExceedBalance(amount);
                    if (isInvalid) validationContext.AddFailure("Amount cannot be greater than balance due.");
                });
        }
    }
}