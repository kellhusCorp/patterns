using OCP.Entities;
using OCP.Enums;

namespace OCP.Specifications;

public class SizeSpecification : Specification<Product>
{
    private readonly Size size;

    public SizeSpecification(Size size)
    {
        this.size = size;
    }
    public override bool IsSatisfied(Product item)
    {
        return item.Size == size;
    }
}