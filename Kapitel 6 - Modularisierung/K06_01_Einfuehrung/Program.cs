namespace K06_01_Einfuehrung
{
    class Program
    {
        static void Main()
        {
            int xVal = 20;
            int yVal = 30;
            
            Console.WriteLine($"Tausche Call by Value - Vorher - xVal = {xVal}, yVal = {yVal}");
            TauscheCallByValue(xVal, yVal);
            Console.WriteLine($"Tausche Call by Value - Nachher - xVal = {xVal}, yVal = {yVal}");
            
            Console.WriteLine($"Tausche Call by Value - Vorher - xVal = {xVal}, yVal = {yVal}");
            TauscheCallByReference(ref xVal, ref yVal);
            Console.WriteLine($"Tausche Call by Value - Nachher - xVal = {xVal}, yVal = {yVal}");
        }
        /// <summary>
        /// Zyklisches Tauschen zwei Werte
        /// Methode mit Werttypen als Parameter
        /// </summary>
        /// <param name="a">Erster int-Parameter</param>
        /// <param name="b">Zweiter int-Parameter</param>
        private static void TauscheCallByValue(int a, int b)
        {
            Console.WriteLine($"Methode a = {a}, b = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"Methode a = {a}, b = {b}");
        }
        private static void TauscheCallByReference(ref int a, ref int b)
        {
            Console.WriteLine($"Methode a = {a}, b = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"Methode a = {a}, b = {b}");
        }
    }
}

