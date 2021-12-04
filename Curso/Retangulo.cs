using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Alura { get; set; }

        public  double Area()
        {
            return Largura * Alura;
        }
        public double Perimetro()
        {
            return 2 * Largura + 2 * Alura;
        }
        public double Diagonal()
        {
            var perimetro = Math.Pow(Largura, 2) + Math.Pow(Alura, 2);
            return perimetro;
        }

        public override string ToString()
        {
            return "\n Area: "
                    + Area().ToString("F2", CultureInfo.InvariantCulture) 
                    + "\n Perimetro: "
                    + Perimetro().ToString("F2", CultureInfo.InvariantCulture) 
                    + "\n Diagonal: " 
                    + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
