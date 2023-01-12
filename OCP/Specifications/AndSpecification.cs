namespace OCP.Specifications;

public class AndSpecification<T> : Specification<T>
{
    private readonly Specification<T> first, second;

    public AndSpecification(Specification<T> first, Specification<T> second)
    {
        this.first = first;
        this.second = second;
    }

    public override bool IsSatisfied(T item)
    {
        return first.IsSatisfied(item) &&
               second.IsSatisfied(item);
    }
}