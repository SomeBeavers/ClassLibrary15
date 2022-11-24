namespace ClassLibrary15;

public class CheckedOperators
{
    public string Name { get; set; }

    public static CheckedOperators operator checked ++(CheckedOperators c)
    {
        return null;
    }

    public static CheckedOperators operator ++(CheckedOperators c)
    {
        throw new NotImplementedException();
    }

    public static CheckedOperators operator checked --(CheckedOperators c)
    {
        return null;
    }

    public static CheckedOperators operator --(CheckedOperators c)
    {
        return null;
    }

    public static CheckedOperators operator checked -(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    public static CheckedOperators operator -(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    public static CheckedOperators operator checked +(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    public static CheckedOperators operator +(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    public static CheckedOperators operator checked *(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    public static CheckedOperators operator *(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    public static CheckedOperators operator /(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    public static CheckedOperators operator checked /(CheckedOperators t1, CheckedOperators t2)
    {
        return null;
    }

    //public static CheckedOperators operator checked <=(CheckedOperators t1, CheckedOperators t2)
    //{
    //    return null;
    //}

    public static explicit operator checked CheckedOperators2(CheckedOperators t1)
    {
        return null;
    }

    public static explicit operator CheckedOperators2(CheckedOperators t1)
    {
        return null;
    }
}

public class CheckedOperators2 : ICheckedOperators2
{
}

public interface ICheckedOperators2
{
    public static ICheckedOperators2 operator ++(ICheckedOperators2 t1)
    {
        return null;
    }

    public void Test()
    {
    }

    public static ICheckedOperators2 operator checked ++(ICheckedOperators2 t1)
    {
        return null;
    }

    public static ICheckedOperators2 operator --(ICheckedOperators2 t1)
    {
        return null;
    }
}