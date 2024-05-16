namespace B03_01_Fahrzeug;

class Test
{
    public void Run()
    {
        Auto auto = new Auto("VW", "Golf", "150");
        Fahrrad fahrrad = new Fahrrad("Cube", "Test12", "8-Gang");

        Console.ReadKey();
    }
    
    static void Main(string[] args)
    {
        Test test = new Test();
        test.Run(); 
    }
}