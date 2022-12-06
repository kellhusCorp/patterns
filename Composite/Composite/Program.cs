using Composite.Entities;

namespace Composite;

internal static class Demo
{
    static void Main()
    {
        var drawing = new GraphicObject
        {
            Name = "MyDrawing"
        };
        
        drawing.Children.Add(new Square {Color = "Red"});
        drawing.Children.Add(new Circle {Color = "Yellow"});

        var group = new GraphicObject();
        
        group.Children.Add(new Circle {Color = "Blue"});
        group.Children.Add(new Square {Color = "Blue"});
        
        drawing.Children.Add(group);

        Console.WriteLine(drawing);

        var firstNeuron = new Neuron();
        var secondNeuron = new Neuron();

        var firstLayer = new NeuronLayer(3);
        var secondLayer = new NeuronLayer(4);
        
        firstNeuron.ConnectTo(secondNeuron);
        firstNeuron.ConnectTo(firstLayer);
        secondLayer.ConnectTo(firstNeuron);
        firstLayer.ConnectTo(secondLayer);
    }
}