namespace B02_02_AutoAnhaenger;

class Test {
    void Run()
    {
        Auto auto = new Auto("VW", "Golf", "UE-JK-250");
        Auto auto2 = new Auto("Skoda", "Okativa", "UE-JK-251");

        Anhaenger anhaenger1 = new Anhaenger("Koch", "Z1", 2000.0);
        Anhaenger anhaenger2 = new Anhaenger("Fahrenhorst", "K1", 450.0);
        
        Console.WriteLine(auto.AsString());
        
        auto.Ankuppeln(anhaenger1);
        Console.WriteLine(auto.AsString());
        
        auto2.Ankuppeln(anhaenger1);
        Console.WriteLine(auto2.AsString());
        
        auto.Abkuppeln();
        Console.WriteLine(auto.AsString());
        
        auto2.Abkuppeln();
        Console.WriteLine(auto2.AsString());

    }

    static void Main()
    {
        Test test = new Test();
        test.Run();

        Console.ReadKey();

    }

}