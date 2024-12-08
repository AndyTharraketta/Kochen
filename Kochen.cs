using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kochen
{
    internal class Kochen
    {
        int nudeln;
        int wasser;
        int fleisch;
        int soße;

        static int rezeptNudeln = 1000;
        static int rezeptWasser = 2000;
        static int rezeptFleisch = 500;
        static int rezeptSoße = 1000;

        public int Nudeln { get => nudeln; set => nudeln = value; }
        public int Wasser { get => wasser; set => wasser = value; }
        public int Fleisch { get => fleisch; set => fleisch = value; }
        public int Soße { get => soße; set => soße = value; }
        public static int RezeptNudeln { get => rezeptNudeln; }
        public static int RezeptWasser { get => rezeptWasser; }
        public static int RezeptFleisch { get => rezeptFleisch; }
        public static int RezeptSoße { get => rezeptSoße; }

        public Kochen(int nudeln, int wasser, int fleisch, int soße)
        {
            this.nudeln = nudeln;
            this.wasser = wasser;
            this.fleisch = fleisch;
            this.soße = soße;
        }

        public void NudelnAuffuellen()
        {
            int auffuellen = RezeptNudeln - nudeln;
            nudeln = RezeptNudeln;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Neuer Bestand: {nudeln} g Nudeln\nEs wurden {auffuellen} g Nudeln aufgefüllt");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-Drücke Taste zum Fortfahren-");
            Console.ReadKey();
        }

        public void WasserAuffuellen()
        {
            int auffuellen = RezeptWasser - wasser;
            wasser = RezeptWasser;
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"Neuer Bestand: {wasser} ml Wasser\nEs wurden {auffuellen} ml Wasser aufgefüllt");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-Drücke Taste zum Fortfahren-");
            Console.ReadKey();
        }

        public void FleischAuffuellen()
        {
            int auffuellen = RezeptFleisch - fleisch;
            fleisch = RezeptFleisch;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Neuer Bestand: {fleisch} g Fleisch\nEs wurden {auffuellen} g Fleisch aufgefüllt");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-Drücke Taste zum Fortfahren-");
            Console.ReadKey();
        }

        public void SoßeAuffuellen()
        {
            int auffuellen = RezeptSoße - soße;
            soße = RezeptSoße;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Neuer Bestand: {soße} ml Soße\nEs wurden {auffuellen} ml Soße aufgefüllt");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-Drücke Taste zum Fortfahren-");
            Console.ReadKey();
        }

        private bool CheckNudeln()
        {
            if (nudeln >= 200) return true;
            else return false;
        }

        private bool CheckWasser()
        {
            if (wasser >= 500) return true;
            else return false;
        }

        private bool CheckFleisch()
        {
            if (fleisch >= 150) return true;
            else return false;
        }

        private bool CheckSoße()
        {
            if (soße >= 250) return true;
            else return false;
        }

        public void EssenKochen()
        {
            if(CheckNudeln() && CheckWasser() && CheckFleisch() && CheckSoße())
            {
                nudeln -= 200;
                wasser -= 500;
                fleisch -= 150;
                soße -= 250;
                Console.WriteLine("Essen wurde zubereitet!\nGuten Appetitt!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-Drücke Taste zum Fortfahren-");
                Console.ReadKey();
            }
            else if (!CheckNudeln() && CheckWasser() && CheckFleisch() && CheckSoße())
            {
                Console.WriteLine("Nicht genügend Nudlen vorhanden!\nBitte Nudeln auffüllen!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-Drücke Taste zum Fortfahren-");
                Console.ReadKey();
            }
            else if (CheckNudeln() && !CheckWasser() && CheckFleisch() && CheckSoße())
            {
                Console.WriteLine("Nicht genügend Wasser vorhanden!\nBitte Wasser auffüllen!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-Drücke Taste zum Fortfahren-");
                Console.ReadKey();
            }
            else if (CheckNudeln() && CheckWasser() && !CheckFleisch() && CheckSoße())
            {
                Console.WriteLine("Nicht genügend Fleisch vorhanden!\nBitte Fleisch auffüllen!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-Drücke Taste zum Fortfahren-");
                Console.ReadKey();
            }
            else if (CheckNudeln() && CheckWasser() && CheckFleisch() && !CheckSoße())
            {
                Console.WriteLine("Nicht genügend Soße vorhanden!\nBitte Soße auffüllen!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-Drücke Taste zum Fortfahren-");
                Console.ReadKey(); ;
            }
            else
            {
                Console.WriteLine("Nicht genügend Zutaten vorhanden!\nBitte alle Zutaten auffüllen!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-Drücke Taste zum Fortfahren-");
                Console.ReadKey();
            }
        }

        public void Auswahl()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\t\t-Pasta Bolognese-\n\nBenötigte Zutaten:\t200 g Nudeln\t500 ml Wasser\t150 g Fleisch\t250 ml Soße\n\nVerfügbare Zutaten:\t{nudeln} g Nudeln\t{wasser} ml Wasser\t{fleisch} g Fleisch\t{soße} ml Soße");
                Console.WriteLine("\nWähle Deine Aktion:\n\t\t\t-1- Essen kochen\t-4- Fleisch auffüllen\n\t\t\t-2- Nudeln auffüllen\t-5- Soße auffüllen\n\t\t\t-3- Wasser auffüllen\t-6- Alles auffülllen");
                string input = Console.ReadLine();
                if (input == "1") EssenKochen();
                else if (input == "2") NudelnAuffuellen();
                else if (input == "3") WasserAuffuellen();
                else if (input == "4") FleischAuffuellen();
                else if (input == "5") SoßeAuffuellen();
                else if (input == "6") 
                {
                    NudelnAuffuellen();
                    WasserAuffuellen();
                    FleischAuffuellen();
                    SoßeAuffuellen();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-Falsche Eingabe!-");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("-Drücke Taste zum Fortfahren-");
                    Console.ReadKey();
                }
            }
        }
    }
}
