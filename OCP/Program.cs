using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large
    }

    public class Product
    {
        public readonly string Name;
        public readonly Color Color;
        public readonly Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach(var p in products)
            {
                if (p.Color == color)
                    yield return p;
            }
        }

        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.Size == size)
                    yield return p;
            }
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
            {
                if (p.Size == size && p.Color == color)
                    yield return p;
            }
        }
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }

    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T item);

        public static Specification<T> operator &(Specification<T> first, Specification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }
    }

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

    //combinator
    public class AndSpecification : Specification<Product>
    {
        private readonly Specification<Product> first, second;

        public AndSpecification(Specification<Product> first, Specification<Product> second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsSatisfied(Product item)
        {
            return first.IsSatisfied(item) &&
                second.IsSatisfied(item);
        }
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var bf = new BetterFilter();

            Console.WriteLine("Large products: ");

            var largeSpec = new SizeSpecification(Size.Large);
            foreach (var p in bf.Filter(products, largeSpec))
                Console.WriteLine($" - {p.Name} is {p.Size}");

            var largeBlueSpec = new AndSpecification(largeSpec, new ColorSpecification(Color.Blue));

            foreach (var p in bf.Filter(products, largeBlueSpec))
                Console.WriteLine($" - {p.Name} is large and blue");
        }
    }
}
