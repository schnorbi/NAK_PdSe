using System;
using System.Collections.Generic;

namespace B02_07_Buch_Autor {
    class Test {

        void Run() {

            Autor autor = new Autor( "J.R.R. Tolkien" );
            Buch buch1  = new Buch( "Lord of the Rings", autor, "Klett Verlag" );
            Buch buch2  = new Buch( "The Hobbit", autor, "Klett Verlag" );

            autor.Print();

        }

        static void Main(string[] args) {
            Test test = new Test();
            test.Run();
            Console.ReadKey();
        }
    }
}