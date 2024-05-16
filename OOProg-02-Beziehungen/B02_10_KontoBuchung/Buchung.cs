namespace B02_10_KontoBuchung;

public class Buchung
{
    #region fields

    private string _text;
    private double _betrag;
    private DateTime _datum;

    #endregion

    #region ctor

    public Buchung(string text, double betrag, ref double kontostand)
    {
        _text = text;
        _betrag = betrag;
        kontostand = kontostand + _betrag;
        _datum = DateTime.Now;
    }

    #endregion
}