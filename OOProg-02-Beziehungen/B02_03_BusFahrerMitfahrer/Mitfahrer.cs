namespace B02_03_BusFahrerMitfahrer;

public class Mitfahrer
{
    #region fields
    
    private string _vorname;
    private string _name;
    
    #endregion
    
    #region ctor

    public Mitfahrer(string vorname, string name)
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