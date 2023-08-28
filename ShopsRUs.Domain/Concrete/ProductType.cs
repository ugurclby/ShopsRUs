using ShopsRUs.Domain.Abstract;

namespace ShopsRUs.Domain.Concrete
{
    public class ProductType: ITable
    {
        public int Id { get; set; }
        public string ProductTypeName { get; set; }
    }
}
