using OCP.Entities;
using OCP.Enums;

namespace OCP.Specifications;

public class ColorSpecification : Specification<Product>
{
    private Color color;

    public ColorSpecification(Color color)
    {
        this.color = color;
    }
    public override bool IsSatisfied(Product item)
    {
        return item.Color == color;
    }
}