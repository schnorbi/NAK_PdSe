using B01_02_Person;

class Test
{
    void Run()
    {
        Person person1 = new Person("Max Meier", 'm', new DateTime(1965, 12, 1));
        Person person2 = new Person("Paula Meier", 'w', new DateTime(1970, 1, 1));
        Person person3 = new Person("Lukas Meier", 'm', new DateTime(1999, 12, 12));

        Console.WriteLine($"Name {person1.GetName()}\nGeschlecht {person1.GetGender()}\nGeburtstdatum {person1.GetBirthDate()}");

        Console.WriteLine($"Name {person2.GetName()}\nGeschlecht {person2.GetGender()}\nGeburtsdatum {person2.GetBirthDate()}");
        
        Console.WriteLine($"Name {person3.GetName()}\nGeschlecht {person3.GetGender()}\nGeburtsdatum{person3.GetBirthDate()}");

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