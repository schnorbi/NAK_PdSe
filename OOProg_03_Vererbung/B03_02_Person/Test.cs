namespace B03_02_Person;

class Test
{
    void Run()
    {
        // Test Methods here...
        Dozent dozent = new Dozent("Thorsten Albers", 'm', "Prof. Dr.", "Gewässerökologie");

        Student student1 = new Student("Lars Müller", 'm', 123456);
        Student student2 = new Student("Mareike Meier", 'w', 987654);

        Console.WriteLine(dozent.GetAnrede());

        Console.WriteLine(student1.GetAnrede());
        Console.WriteLine(student2.GetAnrede());

        Console.ReadKey();
    }

    void Run2()
    {
        // Referenzvariablen der Subklassen
        Dozent dozent = new Dozent("Thorsten Albers", 'm', "Prof. Dr.", "Gewässerökologie");
        Student student1 = new Student("Lars Müller", 'm', 123456);
        Student student2 = new Student("Mareike Meier", 'w', 987654);
        
        // Referenzvariablen der Basisklasse (nur Deklaration)
        Person person; // Statische Typ (Person) wird durch die Deklaration festgelegt

        // Objektzuweisung von Basisklasse zu Referenzvariable der Subklasse ist nicht möglich
        // dozent = person;

        // Zuweisen ist zulässig -> in richtung Generalisierung gilt "is-a"-Beziehung
        // Dozent is-a Person, Student is-a Person
        person = dozent; // dynamischer Typ: wird während der Laufzeit zugewiesen
        person = student1;  
        person = student2;
        
        // Dynamische Typprüfung 
        person = dozent;
        if (person is Dozent)
        {
            // person "is a" dozent
            dozent = (person as Dozent); // Explizite Typwandlung
            Console.WriteLine($"person is a Dozent: {dozent.GetAnrede()}");
        }
        
        person = student2;
        if (person is Student)
        {
            // person "is a" student
            Console.WriteLine($"person is a Student: {(person as Student).GetAnrede()}");
        }

        Console.ReadKey();
    }

    void Run3()
    {
        // Referenzvariablen der Subklassen
        Dozent dozent = new Dozent("Thorsten Albers", 'm', "Prof. Dr.", "Gewässerökologie");
        Student student1 = new Student("Lars Müller", 'm', 123456);
        Student student2 = new Student("Mareike Meier", 'w', 987654);

        List<Person> listPersonen = new List<Person>();

        listPersonen.Add(dozent);
        listPersonen.Add(student1);
        listPersonen.Add(student2);

        foreach (Person person in listPersonen)
        {
            //Console.WriteLine(person.GetAnrede()); 
            if (person is Dozent)
            {
                Dozent dozent1 = (person as Dozent);
                Console.WriteLine(dozent1.GetAnrede());
            }
            else if (person is Student)
            {
                Student student3 = person as Student;
                Console.WriteLine(student3.GetAnrede());
            }
        }
    }

    void Run4()
        {
            // Referenzvariablen der Subklassen
            Dozent dozent = new Dozent("Thorsten Albers", 'm', "Prof. Dr.", "Gewässerökologie");
            Student student1 = new Student("Lars Müller", 'm', 123456);
            Student student2 = new Student("Mareike Meier", 'w', 987654);

            List<Person> listPersonen = new List<Person>();

            listPersonen.Add(dozent);
            listPersonen.Add(student1);
            listPersonen.Add(student2);

            foreach (Person person in listPersonen)
            {
                Console.WriteLine(person.GetAnrede());
            }

            Console.ReadKey();
        }
    
    static void Main(string[] args)
    {
        Test test = new Test();
        //test.Run();
        //test.Run2();
        test.Run4();
    }
}
