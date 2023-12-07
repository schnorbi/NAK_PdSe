namespace B02_01_AutoFahrerMitfahrer;

public class Auto
{
    #region fields

    private string _marke;
    private string _modell;
    private string _kennzeichen;
    
    // Assoziationsvariable
    private Fahrer _fahrer;
    
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
    
    #endregion
}