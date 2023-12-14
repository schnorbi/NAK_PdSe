using System;
using System.Collections.Generic;

namespace B02_07_Buch_Autor;

public class Autor
{
    #region fields

    private string _name;

    private List<Buch> _listBuch;

    #endregion

    #region ctor

    public Autor(string name)
    {
        _name = name;
        _listBuch = new List<Buch>();
    }

    #endregion

    #region methods

    public void Print() {
        Console.WriteLine( "Autor   {0}", _name );
        foreach( Buch buch in _listBuch ) {
            Console.WriteLine();
            buch.Print();
        }
    }


    public void Add( Buch buch) {
        _listBuch.Add( buch );
    }

    #endregion
}