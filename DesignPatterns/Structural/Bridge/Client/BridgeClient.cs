using DesignPatterns.Structural.Bridge.Abstractions;
using DesignPatterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Structural.Bridge.Client;

public static class BridgeClient
{
    public static void Execute()
    {
        Project project = new ProductTeam([new CSharpDeveloper(), new JavaScriptDeveloper()]);
        project.Develop();
        
        project = new PetProject([new CSharpDeveloper()]);
        project.Develop();
    }
}