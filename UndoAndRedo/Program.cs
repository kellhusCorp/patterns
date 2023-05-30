namespace UndoAndRedo;

static class Program
{
    static void Main()
    {
        var textBox = new TextBox();

        textBox.AppendLine("Put some first line");
        textBox.AppendLine("Put some second line");
        textBox.AppendLine("Put some third line");
        Console.WriteLine(textBox);

        textBox.Undo();
        Console.WriteLine($"Undo1: {textBox}");

        textBox.Undo();
        Console.WriteLine($"Undo2: {textBox}");

        textBox.Redo();
        Console.WriteLine($"Redo1: {textBox}");
    }
}