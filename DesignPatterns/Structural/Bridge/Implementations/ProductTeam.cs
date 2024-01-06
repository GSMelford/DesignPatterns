using DesignPatterns.Structural.Bridge.Abstractions;

namespace DesignPatterns.Structural.Bridge.Implementations;

public class ProductTeam(IEnumerable<IDeveloper> developers) : Project(developers)
{
    public override void Develop()
    {
        Console.WriteLine("ProductTeam start work!");
        foreach (var developer in Developers)
        {
            developer.Work();
        }
        Console.WriteLine("ProductTeam end work!");
    }
}