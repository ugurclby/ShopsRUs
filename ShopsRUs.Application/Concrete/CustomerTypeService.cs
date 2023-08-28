using ShopsRUs.Application.Abstract;
using ShopsRUs.Domain.Concrete;
using ShopsRUs.Domain.Enums;

namespace ShopsRUs.Application.Concrete
{
    public class CustomerTypeService:ICustomerTypeService
    {
           public IEnumerable<CustomerType> GetAll()
        {
            List<CustomerType> customerTypes = new();

            foreach (var item in Enum.GetValues(typeof(CustomerTypeEnum)))
            {
                customerTypes.Add(new CustomerType
                {
                    Id = (int)item,
                    CustomerTypeName = item.ToString()
                });
            }
            return customerTypes;
        }
    }
}
