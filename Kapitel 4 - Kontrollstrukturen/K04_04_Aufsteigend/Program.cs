// Drei EIngabewert sortieren

int a,b,c;
Console.WriteLine("Bitte geben Sie a ein"); a = int.Parse(Console.ReadLine());
Console.WriteLine("Bitte geben Sie a ein"); b = int.Parse(Console.ReadLine());
Console.WriteLine("Bitte geben Sie a ein"); c = int.Parse(Console.ReadLine());

int h;

if (a > b)
{
    // Tausche a und b
    h = a;
    a = b;
    b = h;
    Console.WriteLine($"a > b a={a}");
}