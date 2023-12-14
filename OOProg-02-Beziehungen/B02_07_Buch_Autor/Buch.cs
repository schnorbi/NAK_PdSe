namespace B02_07_Buch_Autor;

public class Buch
{
    #region  fields

    private string _titel;
    private string _verlag;

    private Autor _author;

    #endregion

    #region ctor

    public Buch(string titel, Autor autor, string verlag)
    {
        _titel = titel;
        _verlag = verlag;
        
        // Assoziation
        _author = autor;
        _author.Add( this );
    }

    #endregion

    #region methods

    public void Print()
    {
        Console.WriteLine( "Titel  {0}",_titel );
        Console.WriteLine( "Verlag {0}",_verlag );
    }

    #endregion
}