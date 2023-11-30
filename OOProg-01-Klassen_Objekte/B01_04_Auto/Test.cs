using B01_04_Auto;

class Test
{
    void Run()
    {
        // Autos erzeugen
        Auto auto1 = new Auto("VW", "Passat", 2011, 15000.0);
        Auto auto2 = new Auto("BMW", "X5", 2015, 28500.0);
        Auto auto3 = new Auto("Mercedes-Benz", "B190", 2015, 21000.0);
        // Autos ausgeben
        Console.WriteLine(auto1.AsString());
        Console.WriteLine(auto2.AsString());
        Console.WriteLine(auto3.AsString());
        
        // Fahren simulieren
        auto1.Anlassen();
        auto1.Gasgeben(30);
        auto1.Bremsen(10);
        auto1.Lenken(+15.0);
        auto1.Lenken(0);
        auto1.Bremsen(20);
        auto1.Abschalten();
    }

    static void Main(string[] args)
    {
        // Instanz der Klasse Test erzeugen
        Test test = new Test();
        // Objektmethode Run aufrufen
        test.Run();
            
        Console.ReadKey();
        
    }
}