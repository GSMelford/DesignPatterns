using DesignPatterns.Behavioral.Visitor.Shapes;

namespace DesignPatterns.Behavioral.Visitor;

public class ExportVisitor : IVisitor
{
    public void VisitDot(Dot dot)
    {
        Console.WriteLine($"Export {dot.Draw()}");
    }

    public void VisitCircle(Circle circle)
    {
        Console.WriteLine($"Export {circle.Draw()}");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        Console.WriteLine($"Export {rectangle.Draw()}");
    }
}