string strOut;

int i = 33345;

Console.WriteLine();

strOut = $"{i:d8}"; //linksbündig mit 7 Ziffern (mit Nullen aufgefüllt"
Console.WriteLine(strOut);

strOut = string.Format("{0:d7} {1:d}", i, i);
Console.WriteLine(strOut);

Console.WriteLine();

strOut = $"{i,7:d}";
Console.WriteLine(strOut);

strOut = $"{i,-7:d}";
Console.WriteLine(strOut);

double d = 123.456;
strOut = $"{d,8:f3}";
Console.WriteLine(strOut);

// 1. Programm schlägt fehl bei verwendung der Variable
// 2. Die wird z.B. ausgegeben, da Variablen immer mit Null initalisiert werden
// 3. "=" ist der Zuweisungsoperator und "==" ist der Vergleichsoperator
// 4. Da es zu einem Stackoverflow bzw. das Vorzeichenbit wird gesetzt
// 5. double.postiveInfinity bzw. double.negativInfinity
// 6. 1/0 -> nein hingegen 1.0/0.0 -> ja


