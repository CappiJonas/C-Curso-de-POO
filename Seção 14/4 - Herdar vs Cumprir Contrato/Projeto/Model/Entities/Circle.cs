using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Projeto.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

        public override string ToString()
        {
            return $"Circle color: {Color}," +
                   $" radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}," +
                   $" area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
