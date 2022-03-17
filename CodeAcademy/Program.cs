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

            double izambineKvadratu = Math.Pow(10, 2) + Math.Pow(15, 2);
            double izambine = Math.Sqrt(izambineKvadratu);
        }

        
    }
}
