﻿namespace Prototype.Domain.Entities;

public class Foo
{
    public uint Stuff;

    public string Whatever;

    public override string ToString()
    {
        return $"{nameof(Stuff)}: {Stuff}, " +
               $"{nameof(Whatever)}: {Whatever}";
    }
}