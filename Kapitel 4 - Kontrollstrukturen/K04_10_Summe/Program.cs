Console.WriteLine("Berechnen der Summe der Zahlen von 1 bis n"); 
Console.WriteLine("Bitte geben Sie n ein: "); 
int n = int.Parse(Console.ReadLine());

int i = n;
int sum = 0;

// while-Loop
while (i > 0)
{
    sum += i;
    i--;
}

Console.WriteLine("Summe-While = " + sum);


// £For-Loop
sum = 0;

for (i = 1; i <= n; i++)
{
    sum += i;
}

Console.WriteLine("Summe-For = " + sum);