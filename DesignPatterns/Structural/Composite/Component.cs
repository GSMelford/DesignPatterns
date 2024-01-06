namespace DesignPatterns.Structural.Composite;

public abstract class Component
{
    public abstract string NameText { get; set; }
    
    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }
}