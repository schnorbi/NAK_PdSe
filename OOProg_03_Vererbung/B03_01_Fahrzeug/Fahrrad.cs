namespace B03_01_Fahrzeug;

// Fahrrad "ist ein" Fahrzeug
public class Fahrrad : Fahrzeug
{
    #region fields
    private string _schaltung;
    #endregion

    #region props

    public string Schaltung
    {
        get => _schaltung;
    }
    #endregion
   
    #region ctor
    // Standard-ctor von Fahrrad will Standard-Ctor von Fahrzeug aufrufen. Dieser existiert nicht mehr, da wir einen überladenen Konstruktor im Fahrzeug haben (dadurch wird vehindert, dass der Standard-Ctor vom Compiler erzeugt wird
    public Fahrrad(string hersteller, string modell, string schaltung) : base(hersteller, modell)
    {
        _schaltung = schaltung;
    }
    #endregion
   
}