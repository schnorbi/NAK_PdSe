namespace B01_02_Person;

public class Person
{
    #region fields

    private static string _name = "Hans";
    private char _gender;
    private DateTime _birthdate;
    #endregion
   
    #region properties

    public string GetName() { return _name; }

    public char GetGender()
    {
        return _gender;
    }

    public string GetBirthDate()
    {
        return _birthdate.ToShortDateString();
    }
    #endregion
    
    #region ctor
    public Person(string name, char gender, DateTime birthdate)
    {
        _name = name;
        _gender = gender;
        _birthdate = birthdate;
    }
    #endregion ctor
}