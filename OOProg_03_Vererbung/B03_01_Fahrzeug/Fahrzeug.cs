namespace B03_01_Fahrzeug;

public class Fahrzeug
{
    #region fields
    private string _hersteller;
    private string _modell;
    #endregion
    
    #region properties
    public string Hersteller
    {
        get => _hersteller;
    }

    public string Modell
    {
        get => _modell;
    }
    #endregion
    
    #region ctor
    
    // Überladener Konstruktor
    public Fahrzeug(string hersteller, string modell)
    {
        _hersteller = hersteller;
        _modell = modell;
    } 
    #endregion
    
}