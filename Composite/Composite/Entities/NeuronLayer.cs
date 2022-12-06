using System.Collections.ObjectModel;

namespace Composite.Entities;

public class NeuronLayer : Collection<Neuron>
{
    public NeuronLayer(int count)
    {
        while (count-- > 0)
        {
            Add(new Neuron());
        }
    }
}