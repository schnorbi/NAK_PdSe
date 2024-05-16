using System.Reflection;

namespace B03_02_Person;

public class Dozent : Person
{
    #region fields
    protected readonly string _titel;
    protected readonly string _gebiet;
    #endregion

    #region ctor
    public Dozent(string name, char gender, string titel, string gebiet) : base(name, gender)
    {
        _titel = titel;
        _gebiet = gebiet;
    }
    #endregion


    #region methods
    // Überschriebene Objektmethode
    public override string GetAnrede()
    {
        if (_gender == 'm')
            return string.Format($"Sehr geehrter Herr {_titel} {_name}");
        if (_gender == 'w')
            return string.Format($"Sehr geehrte Frau {_titel} {_name}");
        return "Sehr geehrte Damen und Herren";
    }
    #endregion
}