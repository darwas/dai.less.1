using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai.less._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Story "Addieren" : Als Benutzer moechte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            Console.Write("Bitte gibt den ersten Summanden ein: ");
            string ersteSummand = Console.ReadLine();
            Console.Write("Bitte gibt den zweiten Summanden ein: ");
            string zweiteSummand = Console.ReadLine();

            // Wandel Text in die Gleikommazahlen

            double ersteSumandAlsZahl = Convert.ToDouble(ersteSummand);
            double zweiteSumandAlsZahl = Convert.ToDouble(zweiteSummand);

            //Berechung ausfueren

            double sume = ersteSumandAlsZahl + zweiteSumandAlsZahl;
             
            //Ausgabe

            Console.WriteLine("Die Sume ist: " + sume);

            WarteAufBenutzereingabe();



        }
        static void WarteAufBenutzereingabe()
        {
            Console.ReadLine();
        }
    }
}
