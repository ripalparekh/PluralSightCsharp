using System;

class Widget : IDisposable
{
    public void DoSomething()
    {
        Console.WriteLine("Widget.DoSomething called!");
    }

    public void Dispose()
    {
        Console.WriteLine("Widget.Dispose called!");
    }
}
