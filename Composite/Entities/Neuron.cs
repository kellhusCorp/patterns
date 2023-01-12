using System.Collections;

namespace Composite.Entities;

public class Neuron : IEnumerable<Neuron>
{
    public List<Neuron> In, Out;

    // public void ConnectTo(Neuron other)
    // {
    //     Out.Add(other);
    //     other.In.Add(this);
    // }

    public IEnumerator<Neuron> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}