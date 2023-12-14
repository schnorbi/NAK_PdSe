namespace B02_05_Kundenverwaltung;

public class Person
{
    #region fields

    private string _name;
    private string _vorname;
    private string _mail;

    #endregion


    #region properties

    public string Name
    {
        get { return _name; }
    }

    public string Vorname
    {
        get { return _vorname; }
    }
    
    public string Mail
    {
        get { return _mail; }
    }
    #endregion
    
    #region ctor
    public Person(string name, string vorname, string mail)
    {
        _name = name;
        _vorname = vorname;
        _mail = mail;
    }
    #endregion
    
    #region methods
    public string AsString()
    {
        return $"{_name}, {_vorname}\n" +
               $"Mail{_mail}";
    }
    #endregion
}