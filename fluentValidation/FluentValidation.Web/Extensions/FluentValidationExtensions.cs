using Microsoft.AspNetCore.Http;
using System.Linq;

namespace FluentValidation.Web.Extensions
{
    public static class FluentValidationExtensions
    {
        public static IRuleBuilderOptions<T, string> PhoneNumber<T>(this IRuleBuilder<T, string> rule) where T : class
        {
            const string UsPhoneRegex = "\\(\\d{3}\\) \\d{3}-\\d{4}";

            return rule.Matches(UsPhoneRegex).WithMessage("Please enter a phone number (999) 999-9999");
        }

        public static IRuleBuilderInitial<T, IFormFile> MatchesFileExtensions<T>(this IRuleBuilder<T, IFormFile> rule, params string[] allowedExtensions) where T : class
        {
            return rule.Custom((value, context) =>
            {
                if (value == null) return;

                if (allowedExtensions.All(ae => value.FileName.EndsWith(ae) == false))
                {
                    context.AddFailure("File must be in the following formats: " + string.Join(", ", allowedExtensions));
                };
            });
        }
    }
}