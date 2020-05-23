namespace FluentValidation.Web.Models
{
    public class AddressModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string Zip { get; set; }
    }

    public class AddressModelValidator : AbstractValidator<AddressModel>
    {
        public AddressModelValidator()
        {
            RuleFor(m => m.Line1).NotEmpty();
            RuleFor(m => m.City).NotEmpty();
            RuleFor(m => m.StateId).NotEmpty();
            RuleFor(m => m.Zip).Length(5);
        }
    }
}