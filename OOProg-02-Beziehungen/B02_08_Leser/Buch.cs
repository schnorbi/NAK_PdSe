namespace B02_08_Leser;

public class Buch
{
    #region  fields

    private string _titel;
    private string _autor;
    
    // Asoziationsvariable -> Ausleihe [0...*]
    private Ausleihe[] _arrayAusleihen;

    #endregion

    #region ctor

    public Buch(string titel, string autor)
    {
        _titel = titel;
        _autor = autor;
        _arrayAusleihen = new Ausleihe[10];
    }

    #endregion

    #region methods

    public void Print()
    {
        Console.WriteLine( "Titel  {0}",_titel );
        Console.WriteLine( "Autor {0}",_autor );
    }

    public void Ausleihen(int index, Ausleihe ausleihe)
    {
        _arrayAusleihen[index] = ausleihe;
    }

    public void Zurueckgeben(int index)
    {
        _arrayAusleihen[index] = null;
    }

    #endregion
}