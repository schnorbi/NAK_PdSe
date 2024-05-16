namespace B02_10_KontoBuchung;

public class Konto
{
    #region fields

    private string _iban;
    private double _kontostand;
    
    // Assoziationsvaribale
    private List<Buchung> _listBuchungen;

    #endregion

    #region ctor

    public Konto(string iban)
    {
        _iban = iban;
        _kontostand = 0;

        _listBuchungen = new List<Buchung>();
        _listBuchungen.Add(new Buchung("Einzahlen", 0.01, ref _kontostand));
    }

    #endregion

    #region methods

    public void Einzahlen(double betrag)
    {
        _listBuchungen.Add(new Buchung("Einzahlung", betrag, ref _kontostand));
    }

    public void Auszahlen(double betrag)
    {
        _listBuchungen.Add(new Buchung("Auszahlen", -betrag, ref _kontostand));
    }

    #endregion
}