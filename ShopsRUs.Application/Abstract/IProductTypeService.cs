using ShopsRUs.Domain.Abstract;
using ShopsRUs.Domain.Concrete;

namespace ShopsRUs.Application.Abstract
{
    public interface IProductTypeService : IService<ProductType>
    {
        IEnumerable<ProductType> GetAll();
    }
}
