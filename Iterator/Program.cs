namespace Iterator;

internal static class Program
{
    private static void Main()
    {
        //    1
        //   / \
        //  2   3
        // /\   /\
        //4  5 6  7

        var leftSubTree = new Node<int>(2, new Node<int>(4), new Node<int>(5));

        var rightSubTree = new Node<int>(3, new Node<int>(6), new Node<int>(7));

        var root = new Node<int>(1, leftSubTree, rightSubTree);

        var iterator = new InOrderIterator<int>(root);

        var tree = new BinaryTree<int>(root);

        Console.WriteLine(string.Join(",", tree.InOrder.Select(x => x.Value)));

        foreach (var node in tree) Console.WriteLine(node.Value);

        var creature = new Creature();
        creature.Strength = 10;
        creature.Intelligence = 11;
        creature.Agility = 12;

        Console.WriteLine($"Max stat = {creature.MaxStats}, " +
                          $"Avg stat = {creature.AverageStats}," +
                          $"Sum stat = {creature.SumOfStats}");

        foreach (var stats in creature)
        {
            Console.WriteLine(stats);
        }
    }
}