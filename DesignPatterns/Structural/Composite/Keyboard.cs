namespace DesignPatterns.Structural.Composite;

public class Keyboard : Button
{
    public readonly List<Component> Buttons = [];

    public override void Add(Component component)
    {
        Buttons.Add(component);
    }

    public override void Remove(Component component)
    {
        Buttons.Remove(component);
    }
}