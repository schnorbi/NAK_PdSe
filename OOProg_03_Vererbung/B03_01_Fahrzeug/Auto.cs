namespace B03_01_Fahrzeug;

// Fahrrad "ist ein" Fahrzeug
public class Auto : Fahrzeug
{
    #region fields
    private string _leistung;
    #endregion

    #region props

    public string Leistung 
    {
        get => _leistung;
    }
    #endregion
   
    #region ctor
    // Standard-ctor von Auto will Standard-Ctor von Fahrzeug aufrufen. Dieser existiert nicht mehr, da wir einen überladenen Konstruktor im Fahrzeug haben (dadurch wird vehindert, dass der Standard-Ctor vom Compiler erzeugt wird
    public Auto(string hersteller, string modell, string leistung) : base(hersteller, modell)
    {
        _leistung = leistung;
    }
    #endregion
   
}