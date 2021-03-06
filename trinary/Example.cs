using System;
using System.Linq;

public class Trinary
{
    private readonly string value;

    public Trinary(string value)
    {
        this.value = value;
    }

    public int ToDecimal()
    {
        if (IsNotValidTrinary()) return 0;

        return value
            .Select((c, i) => int.Parse(c.ToString()) * ThreeToThePowerOf(value.Length - i - 1))
            .Sum();
    }

    private bool IsNotValidTrinary()
    {
        return !value.All(x => char.IsDigit(x) && int.Parse(x.ToString()) < 3);
    }

    private static int ThreeToThePowerOf(int power)
    {
        return (int)Math.Pow(3, power);
    }
}