using System;
using System.Collections.Generic;

namespace B02_08_Leser {
    class Test {

        void Run()
        {
            Leser leser1 = new Leser("Fritz", "Fischer");
            Leser leser2 = new Leser("Karin", "Müller");

            Buch buch1 = new Buch("Lord of the Rings", "JRR Tolkien");
            Buch buch2 = new Buch("The Hoobit", "JRR Tolkien");
            Buch buch3 = new Buch("The winds of winbter", "Georg RR Martin");
            
            this.Ausleihen(leser1, buch1);
            
            this.Ausleihen(leser2, buch2);
            this.Ausleihen(leser2, buch3);
            
            leser1.Print();
            leser2.Print();
            
            this.Zurueckgeben(leser1);
            this.Zurueckgeben(leser2);
            
            leser1.Print();
            leser2.Print();
        }

        private void Ausleihen(Leser leser, Buch buch)
        {
            Ausleihe ausleihe = new Ausleihe(leser, buch);
            leser.Ausleihen(ausleihe.index, ausleihe);
            buch.Ausleihen(ausleihe.index, ausleihe);
        }

        private void Zurueckgeben(Leser leser)
        {
            Ausleihe[] arrayAusleihen = leser.Leihvorgaenge;
            for (int i = 0; i < arrayAusleihen.Length; i++)
            {
                Ausleihe ausleihe = arrayAusleihen[i];
                if (ausleihe != null)
                {
                    leser.Zurueckgeben(i);
                    ausleihe.Buch.Zurueckgeben(i); 
                }
            }
        }

        static void Main(string[] args) {
            Test test = new Test();
            test.Run();
            Console.ReadKey();
        }
    }
}