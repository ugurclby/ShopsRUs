using ShopsRUs.Domain.Enums;

namespace ShopsRUs.Api.Models
{
    public class GetDiscountModel
    {
        public CustomerTypeEnum? CustomerTypeId { get; set; }
        public DateTime DtCustomerRegister { get; set; }
        public ProductTypeEnum? ProductTypeId { get; set; }
        public decimal Amount { get; set; }

    }
}
