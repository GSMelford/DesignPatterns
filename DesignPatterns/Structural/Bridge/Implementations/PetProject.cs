using DesignPatterns.Structural.Bridge.Abstractions;

namespace DesignPatterns.Structural.Bridge.Implementations;

public class PetProject(IEnumerable<IDeveloper> developers) : Project(developers)
{
    public override void Develop()
    {
        Console.WriteLine("Pet project start work!");
        foreach (var developer in Developers)
        {
            developer.Work();
        }
        Console.WriteLine("Pet project end work!");
    }
}