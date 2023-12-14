namespace B02_05_Kundenverwaltung;

class Test{

    void Run()
    {

        Kunde kunde1 = new Kunde("Ostfalia Hochschule", "Herbert-Meyer-Straße 29556");
        Kunde kunde2 = new Kunde("Nordakademie", "Elmshorn");

        Person person1 = new Person("Kleimann", "Jorin", "j.kleimann@ostfalia.de");
        Person person2 = new Person("Himmelspach", "Jan", "jan.himmelspach@nordakademie.de");
        
        // Hinzufügen der Ansprechpartner bei den Kunden
        kunde1.Update(person1);
        kunde2.Update(person2);


        Verwaltung verwaltung = new Verwaltung();

        try
        {
            verwaltung.Add(kunde1);
            verwaltung.Add(kunde2);
            verwaltung.Print();
            verwaltung.Remove(kunde1);
            verwaltung.Print();
            Kunde kunde = verwaltung.Find("Ostfalia Hochschule");
        }
        catch (ArgumentException argumentException)
        {
            string message = argumentException.Message;
            string trace = argumentException.StackTrace;
            Console.WriteLine("Fehlermeldung: " + message + "\n" + trace);

        }
        catch (IndexOutOfRangeException indexOutOfRangeException)
        {
            string message = indexOutOfRangeException.Message;
            string trace = indexOutOfRangeException.StackTrace;
            Console.WriteLine("Fehlermeldung: " + message + "\n" + trace);
        }
        catch (NullReferenceException nullReferenceException)
        {
            string message = nullReferenceException.Message;
            string trace = nullReferenceException.StackTrace;
            Console.WriteLine("Fehlermeldung: " + message + "\n" + trace); 
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    static void Main()
    {
        Test test = new Test();
        test.Run();

        Console.ReadKey();
    }

}