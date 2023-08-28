using ShopsRUs.Domain.Abstract;
using ShopsRUs.Domain.Concrete;

namespace ShopsRUs.Application.Abstract
{
    public interface ICustomerTypeService : IService<CustomerType>
    {
        IEnumerable<CustomerType> GetAll();
    }
}
