using System;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufruf der Methode
            MaleZeile();
            MaleZeile();
            //string hallo = SagHallo();
            //Console.WriteLine(hallo);
            Console.WriteLine(SagHallo());
            Console.WriteLine(SagHalloZu("Axel"));

            //int a = MaleZeile(); Fehler, da kein Wert

            Console.WriteLine($"Summe: {Add(5.0, 7.0)}");
            Console.WriteLine(IsGroesserZehn(11));
            MaleZeile();

            Console.WriteLine($"Summe: {Add(10, 20, 30)}");

            Console.WriteLine();
            int a = 10; // a Werttyp
            
            // Bei Werttypen als Parameter wird immer mit einer Kopie der Variablen
            // gearbeitet, das Original bleibt unverändert
            // Diese Art der Parameterübergabe wird als Call By Value bezeichnet

            AddFifeToNumber(a); // Hier wird eine Kopie von a übergeben, kein Original!
            Console.WriteLine(a);

            Console.WriteLine();

            // Wenn mit dem Original gearbeitet werden soll, muss der Param. mit dem Schlüsselwort
            // ref sowohl bei der Def., als auch beim Aufruf der Methode übergeben werden.
            // Diese Art der Parameterübergabe wird als Call By Reference bezeichnet
            AddTenToNumber( ref a);
            Console.WriteLine(a);

            Console.WriteLine();

            // Beim Aufruf der Methode kann auf die Angabe des Defaultparam. verzichtet werden
            // Dann wird der Defaultwert genommen.
            // Ein Defaultparam. sollte immer als letzter (letzte) Parameter stehen.
            Console.WriteLine(Volumen(10, 10, 20));
        }

        // Methodensignatur (Methodenkopf) bestehend aus: Rückgabetyp, Methodenname, Parameterliste(kann auch leer sein)

        // Def. einer Methode
        private static void MaleZeile()
        {
            Console.WriteLine("------------------------------------------------------------");
        }

        // Eine Methode mit einem Rückgabetyp
        public static string SagHallo()
        {
            Console.WriteLine("Hallo");
            return "Hallo";
        }

        public static string SagHalloZu(string name)
        {
            return "Hallo " + name;
        }

        // Mehrere Methoden mit dem gl. Namen können nebeneinander nur existieren, wenn sie sich
        // in der Anzahl / im Typ ihrer Param. unterscheiden.
        // Diese Technik wird als Methodenüberladung bezeichnet.
        public static double Add(double param1, double param2)
        {
            return param1 + param2;
        }
        public static double Add(int param1, double param2)
        {
            return param1 + param2;
        }

        public static double Add(double arg1, double arg2, double arg3)
        {
            return arg1 + arg2 + arg3;
        }


        public static bool IsGroesserZehn(int n)
        {
            if (n > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddFifeToNumber(int number)
        {
            number += 5;
            Console.WriteLine($"number innerhalb der Methode: {number}");
        }
        public static void AddTenToNumber(ref int number)
        {
            number += 10;
            Console.WriteLine($"number innerhalb der Methode: {number}");
        }

        // Methoden mit Defaultparameter
        public static double Volumen(double b, double l, double h = 10)
        {
            return b * l * h;
        }

        // Bsp. eines Referenztyps für eine Methoe!



    }
}
