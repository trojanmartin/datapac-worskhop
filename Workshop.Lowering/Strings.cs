using System;
using System.Runtime.CompilerServices;

namespace Workshop.Lowering;

public class Strings
{
    public void Method()
    {   
        int number = 5;
        Console.WriteLine($"Writing number {5}");        
    }
    
    
    public void Method1()
    {
        Console.WriteLine(string.Format("Writing number {0}", 5));
    }
    
    public void Method2()
    {
        DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
        defaultInterpolatedStringHandler.AppendLiteral("Writing number ");
        defaultInterpolatedStringHandler.AppendFormatted(5);
        Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
    }
}