using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korona1
{
    class Kvadraticka_rovnice_real
    {/// <summary>
    /// vyočítá rovnici
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns>výsledek ve stringu</returns>
        public string Count(double a, double b, double c)
        {
            if (a == 0)
            {
                double value = -c / b;
                return String.Format("Není kvadratická rovnice (vysledek linearní rovnice je {0})", value);
            }
            else
            {
                double d = Math.Sqrt((b * b) - (4 * a * c));
                if (d > 0)
                {
                    double value1 = (-b + d) / (2 * a);
                    double value2 = (-b - d) / (2 * a);
                    return String.Format("Rovnice má 2 reálné kořeny x1 = {0}, x2 = {1}", value1, value2);
                }
                else if (d == 0)
                {
                    double value = (-b) / (2 * a);
                    return String.Format("Rovnice má jeden kořen x ={0}" + value);
                }
                else
                {
                    return String.Format("Neexistuje řešení v oblasti reálných čísel");
                }
            }
        }
    }
    
        
    
}
