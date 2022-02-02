namespace Workshop.Lowering;

public class Switch
{
    public void Method()
    {

        var names = new[] {"Peter", "Milan", "Fedor"};
        var name = names[1];
        
        switch (name)
        {
            case "Peter":
                Handle(name);
                break;
            case "Milan":
                Handle(name);
                break;
            case "Fedor":
                Handle(name);
                break;
            case "Andrej":
                Handle(name);
                break;
            case "Robert":
                Handle(name);
                break;
            case "Filip":
                Handle(name);
                break;
        }
    }

    private void Handle(string name)
    {
    }
}