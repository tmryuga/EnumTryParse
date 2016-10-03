public enum Test
{
    val0 = 0,
    val1 = 1,
    val2 = 2,
}

class Program
{
    static void Main(string[] args)
    {
        var result1 = EnumTryParse(null, Test.val0);    // result = val0
        var result2 = EnumTryParse("val1", Test.val0);  // result = val1
        var result3 = EnumTryParse(2, Test.val0);       // result = val2

        Console.ReadLine();
    }

    public static TEnum EnumTryParse<TEnum>(object value, TEnum defaultValue)
    {
        return value != null && Enum.IsDefined(typeof(TEnum), value) ? (TEnum)Enum.Parse(typeof(TEnum), value.ToString()) : defaultValue;
    }
}
