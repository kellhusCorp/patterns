using OCP.Interfaces;
using OCP.Specifications;

namespace OCP.Entities;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, Specification<Product> spec)
    {
        foreach(var i in items)
        {
            if (spec.IsSatisfied(i))
                yield return i;
        }
    }
}