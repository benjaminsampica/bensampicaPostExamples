using FluentValidation.Web.Extensions;
using Microsoft.AspNetCore.Http;

namespace FluentValidation.Web.Models
{
    public class AddEditResumeModel
    {
        public IFormFile File { get; set; }
        public string PhoneNumber { get; set; }
        public AddressModel Address { get; set; }
    }

    public class EditResumeModel : AddEditResumeModel
    {

    }

    public class AddEditResumeModelValidator : AbstractValidator<AddEditResumeModel>
    {
        public AddEditResumeModelValidator()
        {
            RuleFor(p => p.File).MatchesFileExtensions(".pdf", ".docx");
            RuleFor(p => p.PhoneNumber).PhoneNumber();
            RuleFor(p => p.Address).SetValidator(new AddressModelValidator());
        }
    }

    public class EditResumeModelValidator : AbstractValidator<EditResumeModel>
    {
        public EditResumeModelValidator()
        {
            Include(new AddEditResumeModelValidator());
            RuleFor(p => p.File).NotEmpty().MatchesFileExtensions(".pdf", ".docx");
        }
    }
}