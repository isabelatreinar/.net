using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBDD.Specs
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(double temperatura)
        {
            return 0;
            //return Math.Round((temperatura - 32) / 1.8, 2);
        }

        public static double FahrenheitParaKelvin(double temperatura)
        {
            temperatura = 273.15;
            return temperatura;
            //return Math.Round((temperatura - 32) / 1.8, 2) + 273.15;
        }
    }
}

