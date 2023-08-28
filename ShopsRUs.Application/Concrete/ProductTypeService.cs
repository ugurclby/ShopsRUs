using ShopsRUs.Application.Abstract;
using ShopsRUs.Domain.Concrete;
using ShopsRUs.Domain.Enums;

namespace ShopsRUs.Application.Concrete
{
    public class ProductTypeService : IProductTypeService
    {
        public IEnumerable<ProductType> GetAll()
        {
            List<ProductType> productTypes = new();
            var values = Enum.GetValues(typeof(ProductTypeEnum)).Cast<ProductTypeEnum>();
            foreach (var item in Enum.GetValues(typeof(ProductTypeEnum)).Cast<ProductTypeEnum>())
            {
                productTypes.Add(new ProductType
                {
                    Id = (int)item,
                    ProductTypeName = item.ToString()
                });
            }
            return productTypes;
        }
    }
}
