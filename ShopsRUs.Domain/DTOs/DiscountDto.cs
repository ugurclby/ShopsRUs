using ShopsRUs.Domain.Enums;

namespace ShopsRUs.Domain.DTOs

{
    public class DiscountDto
    {
        public CustomerTypeEnum CustomerTypeId { get; set; }
        public DateTime DtCustomerRegister { get; set; }
        public ProductTypeEnum ProductTypeId { get; set; } 
        public decimal Amount { get; set; }

    }
}
