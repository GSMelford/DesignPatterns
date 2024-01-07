using DesignPatterns.Behavioral.Visitor.Shapes;

namespace DesignPatterns.Behavioral.Visitor;

public static class VisitorClient
{
    public static void Execute()
    {
        List<IShape> shapes = [new Circle(), new Dot(), new Rectangle()];
        var exporter = new ExportVisitor();
        shapes.ForEach(x=>x.Accept(exporter));
    }
}