using System.Drawing;

namespace DesignPatterns.Behavioral.Visitor.Shapes;

public class Rectangle : IShape
{
    public void Move(Point point)
    {
        throw new NotImplementedException();
    }

    public string Draw()
    {
        return nameof(Rectangle);
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitRectangle(this);
    }
}