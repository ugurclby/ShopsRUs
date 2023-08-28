using ShopsRUs.Domain.Abstract;

namespace ShopsRUs.Domain.Concrete
{
    public class CustomerType : ITable
    {
        public int Id { get; set; }
        public string CustomerTypeName { get; set; }
    }
}
