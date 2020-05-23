namespace FluentValidation.Web.Models
{
    public class PersonModel
    {
        public PersonNameModel PersonName { get; set; }
        public AddressModel Address { get; set; }
    }

    public class PersonNameModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonModelValidator : AbstractValidator<PersonModel>
    {
        public PersonModelValidator()
        {
            RuleFor(p => p.PersonName).SetValidator(new PersonNameModelValidator());
            RuleFor(p => p.Address).SetValidator(new AddressModelValidator());
        }
    }

    public class PersonNameModelValidator : AbstractValidator<PersonNameModel>
    {
        public PersonNameModelValidator()
        {
            RuleFor(p => p.FirstName).Length(3, 100);
            RuleFor(p => p.LastName).Length(3, 100);
        }
    }
}