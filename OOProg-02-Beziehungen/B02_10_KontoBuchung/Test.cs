using System;
using System.Collections.Generic;

namespace B02_10_KontoBuchung {
    class Test {

        void Run()
        {
            Konto konto = new Konto("DE12345678912340");
            konto.Einzahlen(1000.0);
            konto.Einzahlen(42.0);
            konto.Auszahlen(125.0);
        }

        static void Main(string[] args) {
            Test test = new Test();
            test.Run();
            Console.ReadKey();
        }
    }
}