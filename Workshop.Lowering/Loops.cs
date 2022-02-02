using System;
using System.Collections;
using System.Collections.Generic;

namespace Workshop.Lowering;

public class WannaBeEnumerable
{
    public MyEnumerator GetEnumerator()
    {
        return null;
    }
}

public class MyEnumerator
{
    public object Current { get; }

    public bool MoveNext()
    {
        return true;
    }
}

public class Loops
{
    public void EnumeratorMethod()
    {
        var enumerable = new WannaBeEnumerable();
        
        foreach (var var in enumerable)
        {
            
        }         
    }
    
    
    public void Method()
    {
        List<int> list = new List<int>() {1, 2, 3};

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    
    
    public void Method1()
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        var enumerator = list.GetEnumerator();
        try
        {
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        finally
        {
            ((IDisposable)enumerator).Dispose();
        }
    }
    
    
    // public void Method()
    // {
    //     var values = new[] {1, 2, 3};
    //
    //     foreach (var val in values)
    //     {
    //         Console.WriteLine(val);
    //     }
    //
    //     for (int i = 0; i < values.Length; i++)
    //     {
    //         Console.WriteLine(values[i]);
    //     }
    //
    //     int ii = 0;
    //     while (ii < values.Length)
    //     {
    //         Console.WriteLine(values[ii]);
    //         ii++;
    //     }
    // }
}