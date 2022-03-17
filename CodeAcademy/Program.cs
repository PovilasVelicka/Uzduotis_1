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
            earchArea = 4 * PI * Math.Pow(EARCH_RADIUS, 2);
            erchVolume = 4 / 3 * PI * Math.Pow(EARCH_RADIUS, 2);      

            Console.WriteLine(
                "Programa turi išvesti skaičiavimo rezultatą tesktiniame lange.\n" +
                "Programos atlikimas:\n" +
                "\n");

            //Trikampio izambine

            double izambineKvadratu = Math.Pow(10, 2) + Math.Pow(15, 2);
            double izambine = Math.Sqrt(izambineKvadratu);


            Console.WriteLine("Is viso kintamuju: 3");
            Console.WriteLine($"Kintamasis 1: {Math.Round( earchArea,0)}");
            Console.WriteLine($"Kintamasis 2: {Math.Round(erchVolume,0)}");
            Console.WriteLine($"Kintamasis 3: {Math.Round(izambine,0)}");
            Console.WriteLine($"Suma: {Math.Round( earchArea + erchVolume + izambine,0)}");
            Console.WriteLine($"Vidurkis: {Math.Round((earchArea + erchVolume + izambine)/3,0)}");

        }


    }
}
