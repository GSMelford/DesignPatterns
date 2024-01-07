using System.Drawing;

namespace DesignPatterns.Behavioral.Visitor.Shapes;

public class Circle : IShape
{
    public void Move(Point point)
    {
        throw new NotImplementedException();
    }

    public string Draw()
    {
        return nameof(Circle);
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitCircle(this);
    }
}