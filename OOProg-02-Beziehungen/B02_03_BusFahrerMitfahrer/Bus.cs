namespace B02_03_BusFahrerMitfahrer;

public class Bus
{
    #region fields

    private string _marke;
    private string _modell;
    private string _kennzeichen;
    
    // Assoziationsvariable Fahrer [0...1]
    private Fahrer _fahrer;
    // Assoziationsvariablen Mitfahrer[0...60]
    private Mitfahrer[] _arrayMitfahrer;
    

    #endregion
    
    #region ctor

    public Bus(string marke, string modell, string kennzeichen)
    {
        _marke = marke;
        _modell = modell;
        _kennzeichen = kennzeichen;
        // Array  für Assoziastion erzeugen
        _arrayMitfahrer = new Mitfahrer[60];
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

        foreach (var mitfahrer in _arrayMitfahrer)
        {
            if (mitfahrer == null) continue;
            Console.WriteLine($"Mitfahrer {mitfahrer.AsString()}");
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
        for (int index = 0; index < _arrayMitfahrer.Length; index++)
        {
            if (_arrayMitfahrer[index] == null)
            {
                _arrayMitfahrer[index] = mitfahrer;
                return;
            }
        }
        Console.WriteLine("Alle Mitfahrplätze sind belegt!");
    }

    public void Aussteigen(Mitfahrer mitfahrer)
    {
        for (int index = 0; index < _arrayMitfahrer.Length; index++)
        {
            if (_arrayMitfahrer[index] == mitfahrer)
            {
                _arrayMitfahrer[index] = null;
            }
        }
    }
    #endregion
}