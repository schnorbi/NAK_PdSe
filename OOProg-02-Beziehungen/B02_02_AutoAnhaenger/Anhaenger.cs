namespace B02_02_AutoAnhaenger;

public class Anhaenger
{
    #region fields
    
    private readonly string _marke;
    private readonly string _modell;
    private readonly double _gewicht;

    // Assoziationsvariable

    private Auto _auto;

    #endregion

    #region ctor

    public Anhaenger(string marke, string modell, double gewicht)
    {
        _marke = marke;
        _modell = modell;
        _gewicht = gewicht;
    }

    #endregion

    #region methods

    // Assoziationsmethoden
    public void Ankuppeln(Auto auto)
    {
        if (_auto == null)
        {
            _auto = auto;
        }
    }

    #endregion

}