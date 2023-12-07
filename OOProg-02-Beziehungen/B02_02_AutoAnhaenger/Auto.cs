namespace B02_02_AutoAnhaenger;

public class Auto
{
    #region fields

    private string _marke;
    private string _modell;
    private string _kennzeichen;
    
    // Assoziationsvariable
    private Anhaenger _anhaenger;
    
    
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

    }
    
    // Assoziationsmethoden

    public void Ankuppeln(Anhaenger anhaenger)
    {
        if (_anhaenger == null)
        {
            _anhaenger = anhaenger;
            
        }
    }
    
    #endregion
}