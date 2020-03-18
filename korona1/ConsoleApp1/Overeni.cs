using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korona1
{
    class Overeni
    {
        public static string Error { get; private set; } = "Neplatné číslo, zadejte prosím znovu:";
        private static double a;

        /// <summary>
        /// double parse na požadovaný řetězec, napíše hlášku error a zazní zvuk když to nejde a načte se znova
        /// </summary>
        /// <param name="s">libovolný text</param>
        /// <returns>převedená hodnota</returns>
        public static double OverSChybou(string s)
        {
            if (!double.TryParse(s, out a))
            {
                Console.WriteLine(Error);
                 Console.Write((char)7);
                OverSChybou(Console.ReadLine());
            }
            return a;
        }

        /// <summary>
        /// buď vyíše chybu nebo hodnotu, při chyb hodnota = 0, 
        /// </summary>
        /// <param name="s">libovolný text</param>
        /// <returns>hodnota</returns>
        public static double OverBezChyby(string s)
        {
            if (!double.TryParse(s, out a))
            {
                Console.WriteLine(Error);
                Console.Write((char)7);
            }
                
            return a;
        }
    }
}
