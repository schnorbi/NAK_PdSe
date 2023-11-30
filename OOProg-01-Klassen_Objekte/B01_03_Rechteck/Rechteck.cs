namespace B01_03_Rechteck;

public class Rechteck
{
    #region fields
    // Objektvariablen
    private int _id;
    private double _breite;
    private double _hoehe;
    // Klassenvariable
    private static int lfdNr = 1;
    #endregion
   
    #region properties
   
    private int Id
    {
        get { return _id; }
    }

    public double Hoehe
    {
        get => _hoehe;
    }

    public double Breite
    {
        get { return _breite;}
    }
    #endregion
   
    #region ctor
    public Rechteck()
    {
      
    }

    public Rechteck(double breite, double hoehe)
    {
        _breite = breite;
        _hoehe = hoehe;
        _id = lfdNr;
        lfdNr++;
    }
    #endregion

    #region methods

    public double BerechneFlaeche()
    {
        return _breite * _hoehe;
    }

    public string AsString()
    {
        return $"Rechteck-Nr.{_id,3}" +
               $"Breite {_breite,8:f2}" +
               $"Hoehe {_hoehe,8:f2}";
    }
    #endregion
}