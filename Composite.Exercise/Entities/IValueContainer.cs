using System.Collections;

namespace Composite.Exercise.Entities;

public interface IValueContainer : IEnumerable<int>
{
    
}

class ManyValues : List<int>, IValueContainer
{
    public IEnumerator<int> GetEnumerator()
    {
        return base.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class SingleValue : IValueContainer
{
    public int Value;
    
    public IEnumerator<int> GetEnumerator()
    {
        yield return Value;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public static class ExtensionMethods
{
    public static int SuperSum(this List<IValueContainer> containers)
    {
        int result = 0;
        foreach (var c in containers)
        {
            foreach (var i in c)
            {
                result += i;
            }
        }
        
        return result;
    }
}