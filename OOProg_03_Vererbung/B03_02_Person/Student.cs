namespace B03_02_Person;

public class Student : Person
{
    #region fields
    protected readonly int _matrNr;
    #endregion

    #region ctor

    public Student(string name, char gender, int matrNr) : base(name, gender)
    {
        _matrNr = matrNr;
    }
    #endregion

    #region methods

    #endregion
}