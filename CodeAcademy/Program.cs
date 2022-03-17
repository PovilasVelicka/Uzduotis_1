using System;

namespace CodeAcademy
{
    class Program
    {
        //Zemes rutulio plotas
        //spindulys: 6371;
        public static double earchArea;
        public static double erchVolume;
        const double PI = 3.14;
        const double EARCH_RADIUS = 6371;
        //Zemes turis


        static void Main(string[] args)
        {
            earchArea = PI * EARCH_RADIUS * 2;
            erchVolume = 4 / 3 * PI * Math.Pow(EARCH_RADIUS, 2);
            Console.WriteLine("...");

            //Trikampio izambine

            double izambineKvadratu = Math.Pow(10, 2) + Math.Pow(15, 2);
            double izambine = Math.Sqrt(izambineKvadratu);


            Console.WriteLine("Is viso kintamuju: 3");
            Console.WriteLine($"Kintamasis 1: {earchArea}");
            Console.WriteLine($"Kintamasis 2: {erchVolume}");
            Console.WriteLine($"Kintamasis 3: {izambine}");
            Console.WriteLine($"Suma: {earchArea + erchVolume + izambine}");
            Console.WriteLine($"Vidurkis: {(earchArea + erchVolume + izambine)/3}");
        }


    }
}
