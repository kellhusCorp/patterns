using System.Xml.Serialization;

namespace Prototype.Extensions;

public static class GeneralMethods
{
    public static T DeepCopyXml<T>(this T self)
    {
        using (var ms = new MemoryStream())
        {
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(ms, self);
            ms.Position = 0;
            return (T) serializer.Deserialize(ms);
        }
    }
}