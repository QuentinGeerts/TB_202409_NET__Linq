namespace DemoLambda;

public static class Int32Extensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static int Square(this int number)
    {
        return number * number;
    }

    public static bool IsPrime(this int number)
    {
        if (number < 2) return false;
        
        int bound = (int)Math.Sqrt(number);
        for (int divider = 2; divider <= bound; divider++)
        {
            if (number % divider == 0) return false;
        }

        return true;
    }

    public static int Factorial(this int number)
    {
        if (number < 0) throw new ArgumentException("Number cannot be negative");
        return number == 0 ? 1 : number * Factorial(number -1);
    }
}