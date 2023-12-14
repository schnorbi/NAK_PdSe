namespace B02_08_Leser;

public class Leser
{
    #region fields

    private string _vorname;
    private string _name;
    
    private Ausleihe[] _arrayAusleihen;

    #endregion

    #region properties

    public Ausleihe[] Leihvorgaenge
    {
        get { return _arrayAusleihen; }
    }

    #endregion

    #region ctor

    public Leser(string vorname, string name)
    {
        _vorname = vorname;
        _name = name;
        _arrayAusleihen = new Ausleihe[10];
    }

    

    #endregion

    #region methods

    public void Ausleihen(int index, Ausleihe ausleihe)
    {
        _arrayAusleihen[index] = ausleihe;
    }

    public void Zurueckgeben(int index)
    {
        _arrayAusleihen[index] = null;
    }

    public void Print()
    {
        Console.WriteLine($"{_name, -10} {_vorname, -10}");
        foreach (Ausleihe ausleihe in _arrayAusleihen)
        {
            if (ausleihe != null)
            {
                ausleihe.Buch.Print();
            }
        }
    }
    
    #endregion
}