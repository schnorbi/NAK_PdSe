namespace B02_08_Leser;

public class Ausleihe
{
    #region fields

    private int _index;

    private static int lfdNr = 1;

    // Assoziationsvariablen
    private Leser _leser;
    private Buch _buch;

    #endregion

    #region properties

    public int index
    {
        get { return _index;  }
    }
    
    public Leser Leser
    {
        get { return _leser;  }
    }
    
    public Buch Buch
    {
        get { return _buch;  }
    }

    #endregion

    #region ctor

    public Ausleihe(Leser leser, Buch buch)
    {
        _leser = leser;
        _buch = buch;
        _index = lfdNr++;
    }

    #endregion
}