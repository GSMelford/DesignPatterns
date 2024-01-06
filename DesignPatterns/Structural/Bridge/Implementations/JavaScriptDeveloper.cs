using DesignPatterns.Structural.Bridge.Abstractions;

namespace DesignPatterns.Structural.Bridge.Implementations;

public class JavaScriptDeveloper : IDeveloper
{
    public void Work()
    {
        Console.WriteLine("JavaScript Developer writes code...");
    }
}