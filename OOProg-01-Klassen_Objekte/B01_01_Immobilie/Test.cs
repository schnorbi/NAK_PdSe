namespace B01_01_Immobilie
{
    class Test
    {
        #region methods
        //Objektmethoden
        void Run()
        {
            Immobilie immo01 = new Immobilie("Einfamilienhaus", 200.0, 250000.0, "Max Meier", "Elmshorn");
            
            Immobilie immo02 = new Immobilie("Reihenhaus", 150.0, 125000.0, "Hans Meyer", "Uelzen");
            
            // Von außen zugreifbar: Get Methoden
            Console.WriteLine($"Immobilientyp: {immo01.GetImmobilientyp(), 20}");
            Console.WriteLine($"Verkaufspreis: {immo01.GetVerkaufsPreis(), 20:f1} EUR");
            Console.WriteLine($"Wohnfläche: {immo01.GetWohnflaeche(), 20:f1} m2");

            string antwort = immo01.BearbeiteKontakt();
            Console.WriteLine(antwort);
        }

        static void Main(string[] args)
        {
            // Instanz der Klasse Test erzeugen
            Test test = new Test();
            // Objektmethode Run aufrufen
            test.Run();
        }
        #endregion
    }
}