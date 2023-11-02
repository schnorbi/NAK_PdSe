double dx = 0.2;
double dy = 0.2;

// Sind beider Werte größer oder gleich 0,3 liegt ein Messfehler vor

if (dx >= 0.3 && dy >= 0.3)
{
    
}
else
{
    // Ein Wert kleiner als 0.3
    if (dx < 0.3 || dy < 0.3)
    {
        Console.WriteLine("Eingeschränkt brauchbar"); 
    }
    else
    {
        //Beide Werte kleiner 0,3 Messergebnis: Noch tolerierbar
        if (dx < 0.3 && dy < 0.3)
        {
            Console.WriteLine("Noch tolerierbar");
        }
        else
        {
            //Beide Werte kleiner 0,01 Messergebnis: In Ordnung
            if (dx < 0.01 && dy < 0.01)
            {
                Console.WriteLine("In Ordnung");
            }
        }
    }
}

//Korregierte Version

if (dx < 0.3 || dy < 0.3)
{
    if (dx < 0.3 && dy < 0.3)
    {
        if (dx < 0.01 && dy < 0.01)
        {
            Console.WriteLine("In Ordnung");
        }
        else
        {
            Console.WriteLine("Noch tolerierbar");
        }
    }
    else
    {
        Console.WriteLine("Eingeschränkt brauchbar");
    }
}
else
{
    Console.WriteLine("Messfehler"); 
}