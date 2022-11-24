namespace ClassLibrary15;

public class UnsignedRightShift
{
    public void M(UnsignedRightShift x)
    {
        x >>>= 1;

        Console.WriteLine(x);
    }

    public static UnsignedRightShift operator >>> (UnsignedRightShift c, bool t)
    {
        return null;
    }

    public static UnsignedRightShift operator >>> (UnsignedRightShift c, int t)
    {
        return null;
    }
}