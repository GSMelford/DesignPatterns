using System.Drawing;

namespace DesignPatterns.Behavioral.Visitor.Shapes;

public class Dot : IShape
{
    public void Move(Point point)
    {
        throw new NotImplementedException();
    }

    public string Draw()
    {
        return nameof(Dot);
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitDot(this);
    }
}