using OCP.Specifications;

namespace OCP.Interfaces;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
}