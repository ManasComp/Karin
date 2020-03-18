using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korona1
{
    class Prumer
    {
        private List<double> numbers = new List<double>();

        /// <summary>
        /// pri  dotazu vrátí průměr
        /// </summary>
        private double diametr;
        public double Diametr
        {
            get
            {
                return numbers.Average();
            }
            private set
            {
                diametr = value;
            }
        }

        /// <summary>
        /// dosadí do listu, zjistí průměr
        /// </summary>
        /// <returns>průměr</returns>
        public string Count()
        {
            bool next =true;
            while (next)
            {
                double a = Overeni.OverSChybou(Console.ReadLine());
                if (a == 0)
                {
                    next = false;
                }
                else
                {
                    numbers.Add(a);
                }
            }
            Diametr = numbers.Average();
            return String.Format("Průměr zadané množiny je: " + Diametr);
        }
        
    }
}
