using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korona1
{
    class Mnozina
    {
        private List<double> numbers = new List<double>();

        /// <summary>
        /// pri dotazu na hodnotu vrátí maximum z numbers
        /// </summary>
        private double max;
        public double Max
        {
            get
            {
                return numbers.Max();
            }
            set
            {
                max = value;
            }
        }
        /// <summary>
        /// při dotazu na hodnotu rátí minimum z numbers
        /// </summary>
        private double min;
        public double Min
        {
            get
            {
                return numbers.Min();
            }
            set
            {
                min = value;
            }
        }
        /// <summary>
        /// /Vezme string, rozdělí ho na menší stringy a uloží do pole
        /// </summary>
        /// <param name="cisla">Zadaný string s čísly od uživatele</param>
        public void Count(string cisla)
        {
            char[] split_chars = new char[] { '*', ' '};
            string[] numbers_string = cisla.Split(split_chars, StringSplitOptions.RemoveEmptyEntries);
            for (int i=0; i<numbers_string.Length; i++)
            {
                numbers.Add(Overeni.OverBezChyby(numbers_string[i]));   
            }
            foreach (double cislo in numbers)
                Console.WriteLine(cislo);
        }
    }
}
