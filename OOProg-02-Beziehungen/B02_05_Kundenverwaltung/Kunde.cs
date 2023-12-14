namespace B02_05_Kundenverwaltung;

public class Kunde
{
    #region fields

    private string _id;
    private string _firmenname;
    private string _anschrift;
    // Assoziationsvariable --> Person[0...1]
    private Person _person;
    
    // Statische Variable
    private int lfdNr = 1;

    #endregion

    #region properties

    public string Id
    {
        get { return _id; }
    }
    public string FirmenName
    {
        get { return _firmenname; }
    }
    public string Anschrift
    {
        get { return _anschrift; }
    }

    #endregion
    
    #region ctor

    public Kunde(string firmenName, string anschrift)
    {
        _id = string.Format($"K-{lfdNr++:d5}");
        _firmenname = firmenName;
        _anschrift = anschrift;
    }
    #endregion
    
    #region methods

    public string AsString()
    {
        string s = $"{_firmenname}\n" +
                   $"{_anschrift}\n";
        if (_person !=null)
        {
            s += _person.AsString();
        }
        s += "\n";
        return s;
    }
    
    // Assoziationsmethode --> Person
    public void Update(Person person)
    {
        if (_person == null)
        {
            _person = person;    
        }
         
    }
    
    #endregion
}