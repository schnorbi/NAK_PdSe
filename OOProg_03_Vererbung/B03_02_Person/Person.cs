namespace B03_02_Person;

public class Person
{
    #region fields
    protected readonly string _name;
    protected readonly char _gender;
    #endregion
    
    #region ctor
    // Überladener Konstruktor
    public Person(string name, char gender)
    {
        _name = name;
        _gender = gender;
    }
    #endregion 
    
    #region methods
    // Virtuelle Objektmethode
    public virtual string GetAnrede()
    {
        if (_gender == 'm')
            return string.Format($"Sehr geehrter Herr {_name}");
        if (_gender == 'w')
            return string.Format($"Sehr geehrte Frau {_name}");
        return "Sehr geehrte Damen und Herren";
    }
    #endregion
}