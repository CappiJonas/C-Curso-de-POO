using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Projeto.Model.Entities
{
    class Retangle : AbstractShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"Retangle color: {Color}, " +
                   $"height = {Height.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"width = {Width.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"area = {Area().ToString("F2", CultureInfo.InvariantCulture)}"; 
        }
    }
}
