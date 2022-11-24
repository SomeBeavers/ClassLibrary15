namespace ClassLibrary15;

public class UnsignedRightShift
{
    public UnsignedRightShift(int intProperty)
    {
        IntProperty = intProperty;
    }

    public static int IntProperty { get; set; }

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
        return new UnsignedRightShift(IntProperty >> t);
    }
}