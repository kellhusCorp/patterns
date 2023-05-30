using System.Text;

namespace UndoAndRedo;

public class TextBox
{
    private StringBuilder _sb = new();

    private List<Snapshot?> _changes = new();

    private int _current;
    
    public TextBox()
    {
        _changes.Add(new Snapshot(_sb.DeepCopy()));
    }

    public Snapshot? AppendLine(string line)
    {
        _sb.AppendLine(line);
        var mem = new Snapshot(_sb.DeepCopy());
        _changes.Add(mem);
        ++_current;
        return mem;
    }

    public void Restore(Snapshot? snapshot)
    {
        if (snapshot != null)
        {
            _sb = snapshot.Body;
            _changes.Add(snapshot);
            _current = _changes.Count - 1;
        }
    }

    public Snapshot? Undo()
    {
        if (_current > 0)
        {
            var prevMem = _changes[--_current];
            _sb = prevMem.Body;
            return prevMem;
        }

        return null;
    }

    public Snapshot? Redo()
    {
        if (_current + 1 < _changes.Count)
        {
            var mem = _changes[++_current];
            _sb = mem.Body;
            return mem;
        }

        return null;
    }

    public override string ToString()
    {
        return _sb.ToString();
    }
}