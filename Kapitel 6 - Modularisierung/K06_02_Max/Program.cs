class Programm
{
    static void Main()
    {
        Max3(4, 5, 6);
        Max3(4.4, 5.5, 6.6);
    }

    static int Max3(int a, int b, int c)
    {
        int max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        return max;
    }
    
    static double Max3(double a, double b, double c)
    {
        double max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        return max;
    }
}