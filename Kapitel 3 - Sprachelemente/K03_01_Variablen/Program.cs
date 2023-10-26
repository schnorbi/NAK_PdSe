Console.WriteLine("Deklaration und Initialisierung von Variablen");

//Natürliche Zahlen
//-----------------------------

byte b1 = 3;
ushort us1 = 23;
uint ui1 = 64;
ulong ul1 = 2222;
var a = 100;
long l1 = 123456789;

Console.WriteLine($"b1 = {b1}");
Console.WriteLine($"us1 = {us1}"); //string formate with dollar-string
Console.WriteLine($"l1 = {0}", l1); //string format with index

//Min/Max Values
Console.WriteLine("intMin: " + int.MinValue);
Console.WriteLine("intMax: " + int.MaxValue);

//Gleitkommazahlem
float f1 = -654.321f;
double d1 = 10.0E+6; // Scientific E-Notation

Console.WriteLine("f1 = " +  f1);
Console.WriteLine("d1 = " +  d1);

//Grenzwerte
Console.WriteLine("Double.MinValue ..... " + double.MinValue);
Console.WriteLine("Double.MinValue ..... " + double.MaxValue);
Console.WriteLine("Double.MinValue ..... " + double.NegativeInfinity);
Console.WriteLine("Double.MinValue ..... " + double.PositiveInfinity);

d1 = 1.0 / 0.0;
bool bValue = double.IsInfinity(d1);

// String and char literals

string s1 = "This is a string with text.";

char c1 = 'A';
char c3 = 'b';
char c2 = (char)45;

// numeric literals
long l2 = 12345678912345L;
int i = 0x1111;
decimal dec1 = 12345667812345677.123m;

// char literals
char tab = '\t';
char newl = '\n';

Console.WriteLine("tab: " + tab + tab + tab + ":");

char a1 = 'a';
char b11 = 'b';
char c11 = (char)(a1 + b11);

Console.ReadKey();