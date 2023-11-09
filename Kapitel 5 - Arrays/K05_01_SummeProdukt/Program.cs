
int[] x = {2, 17, 10, 9, 16, 3, 9, 16, 5, 1, 17, 14};

int n = x.Length;
int sum = 0;
int prod = 1;

for (int i = 0; i <= n; i++)
{
    sum += x[i];
    prod *= x[i];
    
    Console.WriteLine($"x[{i, 2}] = {x[i], 2}");
}

Console.WriteLine(sum);
Console.WriteLine(prod);