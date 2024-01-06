namespace DesignPatterns.Structural.Composite;

public static class CompositeClient
{
    public static void Execute()
    {
        Keyboard rootKeyboard = new Keyboard { NameText = "Button0" };
        rootKeyboard.Add(new Button { NameText = "Button1" });
        rootKeyboard.Add(new Button { NameText = "Button2" });

        Keyboard innerKeyboard = new Keyboard { NameText = "Button3" };
        innerKeyboard.Add(new Button { NameText = "Button4" });
        innerKeyboard.Add(new Button { NameText = "Button5" });
        
        rootKeyboard.Add(innerKeyboard);
        rootKeyboard.Add(new Button { NameText = "Button6" });

        foreach (var value in DisplayKeyboardHierarchy(rootKeyboard))
        {
            Console.WriteLine(value);
        }
    }
    
    
    private static IEnumerable<string> DisplayKeyboardHierarchy(Component component)
    {
        if (component is Keyboard keyboard)
        {
            foreach (var value in keyboard.Buttons.SelectMany(DisplayKeyboardHierarchy))
            {
                yield return $"Keyboard: {keyboard.NameText} include {value}";
            }
            yield break;
        }

        yield return $"Button: {(component as Button)!.NameText}";
    }
}