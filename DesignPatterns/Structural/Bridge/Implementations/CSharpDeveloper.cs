using DesignPatterns.Structural.Bridge.Abstractions;

namespace DesignPatterns.Structural.Bridge.Implementations;

public class CSharpDeveloper : IDeveloper
{
    public void Work()
    {
        Console.WriteLine("C# Developer writes code...");
    }
}