using System.Collections;

namespace Iterator;

// Array backed properties

public class Creature : IEnumerable<int>
{
    private int[] stats = new int[3];

    private const int StrengthIndex = 0;

    public int Strength
    {
        get => stats[StrengthIndex];
        set => stats[StrengthIndex] = value;
    }

    private const int AgilityIndex = 1;

    public int Agility
    {
        get => stats[AgilityIndex];
        set => stats[AgilityIndex] = value;
    }

    private const int IntelligenceIndex = 2;

    public int Intelligence
    {
        get => stats[IntelligenceIndex];
        set => stats[IntelligenceIndex] = value;
    }

    public double SumOfStats => stats.Sum();

    public double AverageStats => stats.Average();

    public double MaxStats => stats.Max();
    public IEnumerator<int> GetEnumerator()
    {
        return stats.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int this[int index]
    {
        get
        {
            if (index <= 0) throw new ArgumentOutOfRangeException(nameof(index));
            return stats[index];
        }
        set
        {
            if (index <= 0) throw new ArgumentOutOfRangeException(nameof(index));
            stats[index] = value;
        }
    }
}