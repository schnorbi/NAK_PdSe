namespace B02_01_AutoFahrerMitfahrer;

class Test {
    void Run()
    {
        Auto auto = new Auto("VW", "Golf", "UE-JK-250");

        Fahrer fahrer = new Fahrer("Max", "Meyer");

        Mitfahrer mitfahrer1 = new Mitfahrer("Fischer", "Fritz");
        Mitfahrer mitfahrer2 = new Mitfahrer("Heinrich", "Hans");
        
        auto.Einsteigen(fahrer);
        auto.Print();
        
        auto.Einsteigen(mitfahrer1);
        auto.Print();
        
        auto.Einsteigen(mitfahrer2);
        auto.Print();
        
        auto.Aussteigen();
        auto.Print();
        
        auto.Aussteigen(mitfahrer1);
        auto.Print();
        
        auto.Aussteigen(mitfahrer2);
        auto.Print();
    }

    static void Main()
    {
        Test test = new Test();
        test.Run();

        Console.ReadKey();

    }

}

