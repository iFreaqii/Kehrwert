using System;

/// <summary>
/// Nico Bauer
/// IS218
/// AWE
/// Von einer eingegebenen Zahl soll der Kehrwert ermittelt und dann beide Zahlen ausgegeben werden. 
/// Beachte, dass bei einer Null die Bildung des Kehrwertes nicht möglich ist! Eine entsprechende Meldung soll auf dem Bildschirm ausgegeben werden. 
/// </summary>


namespace Kehrwert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration der benötigten Variablen
            double zahl;
            double kehrwert;
            string weiterrechnen = "";

            do
            {
                Console.WriteLine("Bitte Geben Sie eine Zahl ein, von welcher der Kehrwert gebildet werden soll.");

                zahl = double.Parse(Console.ReadLine());
                kehrwert = 1 / zahl;

                Console.WriteLine("Die eingegebene Zahl lautet: {0} \n\nIhr Kehrwert ist: {1}", zahl, kehrwert);

                Console.WriteLine("\nMöchten Sie für eine weitere Zahl den Kehrwert berechnen?\nAntworten Sie mit (j)a und (n)ein.");
                weiterrechnen = Convert.ToString(Console.ReadLine());
            } 
            while (weiterrechnen != "n");

            Console.WriteLine("");
            Console.ReadKey();










        }
    }
}
