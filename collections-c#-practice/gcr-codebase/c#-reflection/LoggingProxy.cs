using System;
using System.Reflection;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class LoggingProxy : DispatchProxy
{
    private object target;

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine("Calling method: " + method.Name);
        return method.Invoke(target, args);
    }

    public static T Create<T>(T targetObj)
    {
        object proxy = Create<T, LoggingProxy>();
        ((LoggingProxy)proxy).target = targetObj;
        return (T)proxy;
    }
}

class LoggingProxyDemo
{
    static void Main()
    {
        IGreeting greeting =
            LoggingProxy.Create<IGreeting>(new Greeting());

        greeting.SayHello();
    }
}
