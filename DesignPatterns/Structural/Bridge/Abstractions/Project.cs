namespace DesignPatterns.Structural.Bridge.Abstractions;

public abstract class Project(IEnumerable<IDeveloper> developers)
{
    protected readonly IEnumerable<IDeveloper> Developers = developers;
    public abstract void Develop();
}