namespace B01_01_Immobilie;

public class Immobilie
{
    #region fields
    // Objektvariablen / fields
    private string _immobilientyp;
    private double _wohnflaeche;
    private double _verkaufsPreis;
    private string _besitzer;
    private string _adresse;
    #endregion

    #region properties
    public string GetImmobilientyp()
    {
        return _immobilientyp;
    }

    public double GetWohnflaeche()
    {
        return _wohnflaeche;
    }

    public double GetVerkaufsPreis()
    {
        return _verkaufsPreis;
    }
    #endregion

    #region ctor
    // Methode zum Erzeugen von Objekten
    // Methodenname ist wie Klassenname
    // Rückgabetyp fehlt, gibt die Objektadresse zurück
    public Immobilie()
    {
        
    }

    // Überladener Konstruktor
    public Immobilie(string typ, double wflaeche, double preis, string besitzer, string adresse)
    {
        _immobilientyp = typ;
        _wohnflaeche = wflaeche;
        _verkaufsPreis = preis;
        _besitzer = besitzer;
        _adresse = adresse;
    }
    #endregion

    #region methodes
    public string BearbeiteKontakt()
    {
        // Besitzer und Anschrift 
        return $"Besitzer: {_besitzer}\n" + $"Adresse: {_adresse}";
    }
    #endregion
    
}