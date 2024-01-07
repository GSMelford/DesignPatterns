using System.Drawing;

namespace DesignPatterns.Behavioral.Visitor;

public interface IShape : IVisitorAcceptable
{
    void Move(Point point);
    string Draw();
}