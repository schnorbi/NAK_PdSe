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

    public string AsString()
    {
        string s = $"Auto: {_marke} {_modell}";
        if (_anhaenger != null)
            s += $" ist gekuppelt mit {_anhaenger.AsString()}";
        else
            s += " ist ohne Anhaenger";
        return s;
    }

    
    // Assoziationsmethoden

    public void Ankuppeln(Anhaenger anhaenger)
    {
        if (_anhaenger == null)
        {
            _anhaenger = anhaenger;
            _anhaenger.Ankuppeln(this);
        }
        else
        {
            Console.WriteLine(this.AsString());
            Console.WriteLine("Es ist schon ein Anhänger angekuppelt!");
        }

    }

    public void Abkuppeln()
    {
        if (_anhaenger != null)
        {
            _anhaenger.Abkuppeln();
            _anhaenger = null;
        }
    }
    
    #endregion
}