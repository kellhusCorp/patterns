using Bridge.Exercise.Renderers;

namespace Bridge.Exercise.Shapes;

public abstract class Shape
{
    protected IRenderer renderer;

    protected string Name { get; init; }

    protected Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public override string ToString()
    {
        return $"Drawing {Name} as {renderer.WhatToRenderAs}";
    }
}