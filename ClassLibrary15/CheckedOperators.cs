namespace ClassLibrary15;

public class CheckedOperators
{
    public CheckedOperators(int count)
    {
        Count = count;
    }

    public int Count { get; set; }

   
    public static CheckedOperators operator checked +(CheckedOperators t1, CheckedOperators t2)
    {
        // checked
        var sum = t1.Count + t2.Count;
        return new(sum);
    }

    public static CheckedOperators operator +(CheckedOperators t1, CheckedOperators t2)
    {
        // unchecked
        var sum = t1.Count + t2.Count;
        return new(sum);
    }
}