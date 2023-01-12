using System.Runtime.Serialization;
using System.Text;

namespace Decorator.Entities;

public class CodeBuilder
{
    private readonly StringBuilder builder = new();

    private int indentLevel;

    public int MaxCapacity => builder.MaxCapacity;

    public CodeBuilder AppendLine(string? value)
    {
        builder.AppendLine(value);
        return this;
    }

    public CodeBuilder Replace(string oldValue, string? newValue, int startIndex, int count)
    {
        builder.Replace(oldValue, newValue, startIndex, count);
        return this;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        ((ISerializable) builder).GetObjectData(info, context);
    }

    public CodeBuilder Append(bool value)
    {
        builder.Append(value);
        return this;
    }

    public CodeBuilder Append(byte value)
    {
        builder.Append(value);
        return this;
    }

    public CodeBuilder Append(char value)
    {
        builder.Append(value);
        return this;
    }

    public CodeBuilder Append(char value, int repeatCount)
    {
        builder.Append(value, repeatCount);
        return this;
    }

    public CodeBuilder Indent()
    {
        indentLevel++;
        return this;
    }

    public override string ToString()
    {
        return builder.ToString();
    }
}