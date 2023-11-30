using B01_03_Rechteck;

class Test
{
    void Run()
    {
        // Rechteck 1 
        Rechteck rechteck1 = new Rechteck(2.5, 1.5);
        // Rechteck 2
        Rechteck rechteck2 = new Rechteck(2.0, 2.0);
        // Rechteck 3
        Rechteck rechteck3 = new Rechteck(1.5, 2.5);

        double summe = rechteck1.BerechneFlaeche() + rechteck2.BerechneFlaeche() + rechteck3.BerechneFlaeche();

        Console.WriteLine(rechteck1.AsString());
        Console.WriteLine(rechteck2.AsString());
        Console.WriteLine(rechteck3.AsString());
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