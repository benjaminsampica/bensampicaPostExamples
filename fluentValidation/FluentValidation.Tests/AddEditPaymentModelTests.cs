using FluentValidation.TestHelper;
using FluentValidation.Web.Models;
using FluentValidation.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentValidation.Tests
{
    [TestClass]
    public class AddEditPaymentModelTests
    {
        private AddEditPaymentModelValidator _validator;

        [TestInitialize]
        public void Initialize()
        {
            var service = new PaymentValidateService();
            _validator = new AddEditPaymentModelValidator(service);
        }

        [TestMethod]
        public void Amount_GreaterThan_BalanceOfTen_IsInvalid() => _validator.ShouldHaveValidationErrorFor(p => p.Amount, 10.01m);

        [TestMethod]
        public void Amount_Equals_BalanceOfTen_IsValid() => _validator.ShouldNotHaveValidationErrorFor(p => p.Amount, 10);

        [TestMethod]
        public void Amount_LessThan_BalanceOfTen_IsValid() => _validator.ShouldNotHaveValidationErrorFor(p => p.Amount, 9);

        [TestMethod]
        public void Amount_BalanceError_HasCustomErrorMessage() => _validator.ShouldHaveValidationErrorFor(p => p.Amount, int.MaxValue).WithErrorMessage("Amount cannot be greater than balance due.");

        [TestMethod]
        public void Amount_Zero_IsInvalid() => _validator.ShouldHaveValidationErrorFor(p => p.Amount, 0);

        [TestMethod]
        public void Amount_Negative_IsInvalid() => _validator.ShouldHaveValidationErrorFor(p => p.Amount, -1);
    }
}