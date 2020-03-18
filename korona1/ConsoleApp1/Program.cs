using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korona1
{

    class Program
    {
        static void Main()
        {
            bool next = true;
            
            Console.ForegroundColor = ConsoleColor.Green;

            while (next)
            {
                Console.WriteLine("Vítejte v aplikaci \"CYKLY V C#\"");
                Console.WriteLine("\t pro zjištění minima a maxima ze zadané množiny čísel napište \"množina\" ");
                Console.WriteLine("\t pro zjištění aritmetického průměru ze zadané množiny čísel napište \"průměr\" ");
                Console.WriteLine("\t pro výpočet kořenů kvadratické rovnice napiště \"kořeny\" ");
                Console.WriteLine("\t \t příkaz potvr,ďte pomocí klávesy ENTER");

                string prikaz = Console.ReadLine().Trim().ToLower();
                
                if (prikaz == "množina")
                {
                    Console.Clear();
                    Mnozina mnozina = new Mnozina();
                    Console.WriteLine("Zvolil/a jste si zjištění maxima a minima ze zadané množiny čísel");
                    Console.WriteLine("Zadejte čísla oddělené mezerou nebo znakem *");
                    mnozina.Count(Console.ReadLine());
                    Console.WriteLine("Maximum je: {0}", mnozina.Max);
                    Console.WriteLine("Minimum je: {0}", mnozina.Min);
                }
                else if (prikaz == "průměr")
                {
                    Console.Clear();
                    Prumer prumer = new Prumer();
                    Console.WriteLine("Zvolil/a jste si výpočet aritmetického průměru čísel ze zadané množiny");
                    Console.WriteLine("Zadejte číslo a potvrďte ENTER, v případě zadání textu bude číslo rovno nule");
                    Console.WriteLine(prumer.Count());
                }
                else if (prikaz == "kořeny")
                {
                    Console.Clear();
                    Kvadraticka_rovnice_real kvadraticka = new Kvadraticka_rovnice_real();
                    Console.WriteLine("Zvolil/a jste si řešení kvadratické rovnice");
                    Console.WriteLine("Zadejte postupně koeficienty a,b,c kvadratické rovnice ax^2+bx+c=0");
                    Console.WriteLine("příkaz potvrďte pomocí klávesy ENTER");
                    Console.Write("Zadejte a: ");
                    double a = Overeni.OverSChybou(Console.ReadLine());
                    Console.Write("Zadejte b: ");
                    double b = Overeni.OverSChybou(Console.ReadLine());
                    Console.Write("Zadejte c: ");
                    double c = Overeni.OverSChybou(Console.ReadLine());
                    Console.WriteLine(kvadraticka.Count(a, b, c));
                }
                else
                {
                    Console.WriteLine("Neplatný text");
                }
                Console.WriteLine();
                Console.WriteLine("Přejete si pokračovat? zmáčkěte ENTER, pokud ne, stiskněte cokoliv jiného");
                if ((ConsoleKey)Console.ReadKey().KeyChar != ConsoleKey.Enter)
                {
                    next = false;
                }
                Console.Clear();
            }
        }
    }
}
