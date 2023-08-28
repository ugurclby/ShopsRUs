using FluentValidation;
using FluentValidation.Results;
using ShopsRUs.Api.Models;

namespace ShopsRUs.Api.Validation
{
    public class CalculateValidator: AbstractValidator<GetDiscountModel>
    {
        public CalculateValidator()
        {
            RuleFor(x => x.CustomerTypeId).IsInEnum().WithMessage("Customer Type Id is not valid");
            RuleFor(x => x.CustomerTypeId).NotEmpty().WithMessage("Customer Type Id is required");
            RuleFor(x => x.DtCustomerRegister).NotEmpty().WithMessage("Customer Register Date is required");
            RuleFor(x => x.ProductTypeId).IsInEnum().WithMessage("Product Type Id is not valid");
            RuleFor(x => x.ProductTypeId).NotEmpty().WithMessage("Product Type Id is required");
            RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Amount must be greater than 0"); 
        }
    }
}
