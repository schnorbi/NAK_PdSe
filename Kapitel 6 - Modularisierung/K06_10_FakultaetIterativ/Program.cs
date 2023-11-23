using System.Numerics;

class Programm
{
    static void Main()
    {
        int a = 15;
        long b = CalcFakulIterativ(a);
        long c = CalcFakulRecursiv(a);
        
        Console.WriteLine($"\nFakultät (Iterativ) von {a} ist {b}");
        Console.WriteLine($"\nFakultät (Rekursiv) von {a} ist {c}");

        BigInteger fib = FibonnaciRecursiv(5);
    }

    private static long CalcFakulIterativ(int n)
    {
        long fakul = 1;
        for (int i = 1; i <= n; i++)
        {
            fakul *= i;
            Console.WriteLine($"Durchlauf {i,3:d} mit dem Ergebnis {fakul,30:d}");
        }
        return fakul;
    }

    public static int CalcFakulRecursiv(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalcFakulRecursiv(n - 1);
    }

    private static BigInteger FibonnaciRecursiv(int n)
    {
        if (n == 1 || n == 0)
        {
            Console.WriteLine($"Rückwärts f({n,2:d} = 1");
            return 1;
        }
        else
        {
            Console.WriteLine($"Rekursion n = {n}");
            BigInteger fn = FibonnaciRecursiv(n - 1) + FibonnaciRecursiv(n - 2);
            Console.WriteLine($"Rückwärts f({n,2:d} = {fn,30:d}");
            return fn;
        }
    }
}