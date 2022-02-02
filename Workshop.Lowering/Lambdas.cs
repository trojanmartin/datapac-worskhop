using System;

namespace Workshop.Lowering;

public class Lambdas
{
    private string lastName = "Novak";

    public void Method()
    {
        Helper c = new Helper();
        c.name = "Maros";
        c._this = this;
        Action<string> action = c._action;
        action("Ahoj");
    }
    
    private class Helper
    {
        public Lambdas _this;
        public string name;
        internal void _action(string text)
        {
            Console.WriteLine(text + name +  _this.lastName);
        }   
    }
}