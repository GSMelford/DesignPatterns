namespace DesignPatterns.Structural.Composite;

public class Button : Component
{
    public override string NameText { get; set; } = null!;

    public bool IsEnable { get; set; } = true;
    public bool IsBack { get; set; } = false;
    public int Index { get; set; }
    public int Line { get; set; }
}