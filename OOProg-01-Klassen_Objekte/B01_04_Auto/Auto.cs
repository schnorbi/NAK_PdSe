namespace B01_04_Auto;

public class Auto
{
    #region fields
    private readonly string _marke;
    private readonly string _modell;
    private readonly int _baujahr;
    private double _preis;
    #endregion
    
    #region properties
    public string Marke
    {
        get { return _marke; }
    }

    public string Modell
    {
        get { return _modell; }
    }

    public int Baujahr
    {
        get { return _baujahr; }
    }

    public double Preis
    {
        get { return _preis; }
        set { _preis = value; }
    }

    private string Bezeichnung
    {
        get { return _marke + " " + _modell; }
    }
    #endregion
    
    #region ctor
    public Auto(string marke, string modell, int baujahr, double preis)
    {
        _marke = marke;
        _modell = modell;
        _baujahr = baujahr;
        _preis = preis;
    }
    #endregion
    
    #region methods

    public void Anlassen()
    {
        Console.WriteLine($"Auto.Anlassen ({Bezeichnung, -20})");
    }

    public void Abschalten()
    {
        Console.WriteLine($"Auto.Abschalten ({Bezeichnung, -20})");
    }

    public void Gasgeben(int prozent)
    {
        Console.WriteLine($"Auto.Gasgeben ({Bezeichnung, -20} {prozent, 3}%)");
    }
    
    public void Bremsen(int prozent)
    {
        Console.WriteLine($"Auto.Bremsen ({Bezeichnung, -20} {prozent, 3}%)");
    }

    public void Lenken(double richtung)
    {
        Console.WriteLine($"Auto.Lenken ({Bezeichnung, -20} {richtung, 3}°)");
    }

    public string AsString()
    {
        return $"Marke {_marke,-14} Modell {_modell,-10} Baujahr {_baujahr,6} Preis: {_preis,10}EUR";
    } 
    
    
    #endregion


}