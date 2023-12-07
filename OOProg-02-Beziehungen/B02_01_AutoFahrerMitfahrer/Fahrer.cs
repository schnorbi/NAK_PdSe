namespace B02_01_AutoFahrerMitfahrer;

public class Fahrer
{
    #region fields

    private string _vorname;
    private string _name;

    #endregion

    #region ctor

    public Fahrer(string vorname, string name)
    {
        _vorname = vorname;
        _name = name;
    }

    #endregion

    #region methods

    public string AsString()
    {
        return _vorname + " " + _name;
    }

    #endregion    
}