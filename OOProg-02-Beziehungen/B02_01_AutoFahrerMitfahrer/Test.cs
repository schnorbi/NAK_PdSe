namespace B02_01_AutoFahrerMitfahrer;

class Test {
    void Run()
    {
        Auto auto = new Auto("VW", "Golf", "UE-JK-250");

        Fahrer fahrer = new Fahrer("Max", "Meyer");
        
        auto.Einsteigen(fahrer);
        auto.Print();
        auto.Aussteigen();
        auto.Print();
    }

    static void main()
    {
        Test test = new Test();
        test.Run();

        Console.ReadKey();

    }

}

