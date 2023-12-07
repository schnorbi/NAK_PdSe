namespace B02_01_AutoFahrerMitfahrer;

public class Auto
{
    #region fields

    private string _marke;
    private string _modell;
    private string _kennzeichen;
    
    // Assoziationsvariable Fahrer [0...1]
    private Fahrer _fahrer;
    
    // Assoziationsvariable Mitfahrer [0...2]
    private Mitfahrer _mitfahrer1;
    private Mitfahrer _mitfahrer2;
    
    #endregion

    #region ctor

    public Auto(string marke, string modell, string kennzeichen)
    {
        _marke = marke;
        _modell = modell;
        _kennzeichen = kennzeichen;
    }

    #endregion

    #region methods
    
    // Objektmethoden

    public void Print()
    {
        Console.WriteLine($"\n{_marke} {_modell} {_kennzeichen}");
        if (_fahrer != null)
        {
            Console.WriteLine($"Fahrer: {_fahrer.AsString()}");
        }

        if (_mitfahrer1 != null)
        {
            Console.WriteLine($"Mitfahrer: {_mitfahrer1.AsString()}");
        }
        
        if (_mitfahrer2 != null)
        {
            Console.WriteLine($"Mitfahrer: {_mitfahrer2.AsString()}");
        }
    }
    
    // Assoziationsmethoden
    
    public void Einsteigen(Fahrer fahrer)
    {
        _fahrer = fahrer;
    }

    public void Aussteigen()
    {
        _fahrer = null;
    }

    public void Einsteigen(Mitfahrer mitfahrer)
    {
        if (_mitfahrer1 == null)
        {
            _mitfahrer1 = mitfahrer;
            return;
        }
        else if (_mitfahrer2 == null)
        {
            _mitfahrer2 = mitfahrer;
            return;
        }
        Console.WriteLine("Alle Mitfahrerplätze sind belegt");
    }
    
    public void Aussteigen(Mitfahrer mitfahrer)
    {
        if (_mitfahrer1 == mitfahrer)
        {
            _mitfahrer1 = null;
            return;
        }
        else if (_mitfahrer2 == mitfahrer)
        {
            _mitfahrer2 = null;
            return;
        }
        
    }
    
    #endregion
}