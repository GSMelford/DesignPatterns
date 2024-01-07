namespace DesignPatterns.Behavioral.Visitor;

public interface IVisitorAcceptable
{
    void Accept(IVisitor visitor);
}