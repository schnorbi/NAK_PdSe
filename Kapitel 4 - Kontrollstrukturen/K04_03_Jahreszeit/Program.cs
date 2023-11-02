class Program
{
    static void Main(string[] args)
    {
        string strKey = Console.ReadLine();
        int i = 0;
        if (!int.TryParse(strKey, out i))
        {
            Console.WriteLine("\nEingabefehler");
            Console.ReadLine();
        }

        string strJahreszeit = string.Empty;

        switch (i)
        {
            case  >=3 and <=5:
                strJahreszeit = "Frühling";
                break;
            case >=6 and <=8:
                strJahreszeit = "Sommer";
                break;
            case >=9 and <=11:
                strJahreszeit = "Herbst";
                break;
            case 12 or 1 or 2:
                strJahreszeit = "Winter";
                break;
        }
        
        Console.WriteLine(strJahreszeit);
        
    }
    
}