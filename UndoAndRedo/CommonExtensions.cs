using System.Runtime.Serialization.Formatters.Binary;

namespace UndoAndRedo;

internal static class CommonExtensions
{
    [Obsolete("This is obsolete mthd")]
    internal static TSource DeepCopy<TSource>(this TSource source)
    {
        var binaryFormatter = new BinaryFormatter();
        using var memoryStream = new MemoryStream();
        binaryFormatter.Serialize(memoryStream, source);
        memoryStream.Position = 0;
        return (TSource) binaryFormatter.Deserialize(memoryStream);
    }
}