using ShopsRUs.Domain.Abstract;

namespace ShopsRUs.Application.Abstract
{
    public interface IService<T> where T : ITable
    {
        IEnumerable<T> GetAll();
    }
}
