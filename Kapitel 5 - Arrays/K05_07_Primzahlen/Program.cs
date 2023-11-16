// Endwert einlesen
Console.WriteLine("Bis zu welcher Zahl sollen die Primzahlen berechnet werden?");
int max = int.Parse(Console.ReadLine());

// Feld bCancel mit max logischen Werten erzeugen
// false --> noch nicht gestrichen
bool[] bCancel = new bool[max];
for (int i = 0; i < max; i++)
{
    bCancel[i] = false;
}
for (int i = 2; i <= max; i++)
{
    // Wenn das Feld noch nicht gestrichen
    if (bCancel[i-1] != true)
    {
        // Primzahl gefunden
        Console.WriteLine(i + " ist eine Primzahl");
    }
    // Von gewählter Zahl aus alle Elemente durchlaufen und auf teilbarkeit ohne rest vergleichen
    for (int j = 2 * i; j <= max; j+=i)
    {
        // Alle Zahlen streichen die Vielfache der Primzahl sind
        if (j % i == 0)
            bCancel[j-1] = true;
    }//end for
} //end outer for 

Console.ReadKey();