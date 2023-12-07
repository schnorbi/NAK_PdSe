namespace B02_03_BusFahrerMitfahrer;

class Test{

    void Run()
    {
        Bus bus = new Bus("Mercedes-Benz", "Tourismo", "HH-VV-123");

        Fahrer fahrer = new Fahrer("Max", "Meyer");
        
        Mitfahrer mitfahrer1 = new Mitfahrer("Fischer", "Fritz");
        Mitfahrer mitfahrer2 = new Mitfahrer("Heinrich", "Hans");
        Mitfahrer mitfahrer3 = new Mitfahrer("Fischer", "Frank");
        Mitfahrer mitfahrer4 = new Mitfahrer("Horst", "Hans");
        
        bus.Einsteigen(fahrer);
        bus.Print();
        
        bus.Einsteigen(mitfahrer1);
        bus.Einsteigen(mitfahrer2);
        bus.Einsteigen(mitfahrer3);
        bus.Einsteigen(mitfahrer4);
        bus.Print();
        
        bus.Aussteigen(mitfahrer3);
        bus.Print();
    }

    static void Main()
    {
        Test test = new Test();
        test.Run();

        Console.ReadKey();
    }
}