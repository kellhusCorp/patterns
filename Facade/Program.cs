public class Generator
{
    private static readonly Random random = new Random();

    public List<int> Generate(int count)
    {
        return Enumerable.Range(0, count)
            .Select(_ => random.Next(1, 6))
            .ToList();
    }
}

public class Splitter
{
    public List<List<int>> Split(List<List<int>> array)
    {
        var result = new List<List<int>>();

        var rowCount = array.Count;
        var colCount = array[0].Count;
        
        for (int r = 0; r < rowCount; ++r)
        {
            var theRow = new List<int>();
            for (int c = 0; c < colCount; ++c)
                theRow.Add(array[r][c]);
            result.Add(theRow);
        }
        
        for (int c = 0; c < colCount; ++c)
        {
            var theCol = new List<int>();
            for (int r = 0; r < rowCount; ++r)
                theCol.Add(array[r][c]);
            result.Add(theCol);
        }
        
        var diag1 = new List<int>();
        var diag2 = new List<int>();
        for (int c = 0; c < colCount; ++c)
        {
            for (int r = 0; r < rowCount; ++r)
            {
                if (c == r)
                    diag1.Add(array[r][c]);
                var r2 = rowCount - r - 1;
                if (c == r2)
                    diag2.Add(array[r][c]);
            }
        }

        result.Add(diag1);
        result.Add(diag2);

        return result;
    }
}

public class Verifier
{
    public bool Verify(List<List<int>> array)
    {
        if (!array.Any()) return false;

        var expected = array.First().Sum();

        return array.All(t => t.Sum() == expected);
    }
}

/// <summary>
/// This is facade for generator, splitter, verifier
/// </summary>
public class MagicSquareGenerator
{
    private Generator generator = new Generator(); 
    
    private Splitter splitter = new Splitter();
    
    private Verifier verifier = new Verifier();
      
    public List<List<int>> Generate(int size)
    {
        bool isMagic = false;
        
        List<List<int>> matrix;
        
        do
        {
            matrix = new List<List<int>>(size)
            {
                generator.Generate(size),
                generator.Generate(size),
                generator.Generate(size)
            };
            
            var splitData = splitter.Split(matrix);

            isMagic = verifier.Verify(splitData);

        } while (!isMagic);

        return matrix;
    }
}

static class Program
{
    static void Main()
    {
        var magicGenerator = new MagicSquareGenerator();
        magicGenerator.Generate(3);
    }
}