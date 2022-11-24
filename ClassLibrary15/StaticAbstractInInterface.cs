namespace ClassLibrary15;

public interface IStaticAbstractInInterface<T> where T : new()
{
    static abstract T StaticAbstractMethod(int t);

    static virtual T StaticVirtualMethod(string s)
    {
        return new T();
    }
}