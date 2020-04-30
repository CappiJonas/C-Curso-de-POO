using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1
{
    class ConversorDeMoeda
    {
        public static double cotacaoDolar;
        public static double valorDolar;

        public static double ValorPagoEmReias()
        {
            return cotacaoDolar * valorDolar + cotacaoDolar * valorDolar * 6.0 / 100.0;
        }
    }
}
