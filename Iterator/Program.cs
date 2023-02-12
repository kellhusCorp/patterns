namespace Iterator;

internal static class Program
{
    static void Main()
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

        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.Current.Value);
        }
    }
}