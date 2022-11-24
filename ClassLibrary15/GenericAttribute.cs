namespace ClassLibrary15;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
public sealed class GenericAttribute<T,U> : Attribute where T: ParentClass where U : struct
{
    public GenericAttribute(string name)
    {
        Console.WriteLine(name);
    }
}

public class ParentClass
{
}