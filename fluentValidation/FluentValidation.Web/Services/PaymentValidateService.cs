namespace FluentValidation.Web.Services
{
    public interface IPaymentValidateService
    {
        bool DoesAmountExceedBalance(decimal amount);
    }
    public class PaymentValidateService : IPaymentValidateService
    {
        const decimal Balance = 10.00m;

        public bool DoesAmountExceedBalance(decimal amount)
        {
            return amount > Balance;
        }
    }
}