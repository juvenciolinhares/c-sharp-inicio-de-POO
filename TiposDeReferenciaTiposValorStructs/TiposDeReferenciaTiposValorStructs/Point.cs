using System;
using System.Collections.Generic;
using System.Text;

namespace TiposDeReferenciaTiposValorStructs
{   /*
     * criar um struct: adiciona uma classe normal, depois troca o nome class por struct
     */

    internal struct Point//troquei class por struct
    {
        //atributos:
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

    }
}
