using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_exaam_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime jaar = new DateTime(2017, 1, 1);

             DateTime nieuwjaar = new DateTime(2027, 1, 1);


             while (jaar.Year < nieuwjaar.Year)
             {
                 jaar = jaar.AddYears(1);
                 Console.WriteLine("{0} : Het is vandaag {1}, Happy Nieuwjaar!!! ", jaar.Year, jaar.DayOfWeek);
            }

            //DateTime verjaardag = new DateTime(2001, 11, 19);

           // for (int x = 0; x <= 100; x++)
            //{
            //    verjaardag = verjaardag.AddYears(1);
            //
             //   if (verjaardag.DayOfWeek == DayOfWeek.Wednesday)
             //   {
             //       Console.WriteLine("in {0} verjaar je op woensdag ", verjaardag.Year);
            //
             //   }
             // }
        }
    }
}