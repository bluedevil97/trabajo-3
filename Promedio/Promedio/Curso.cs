using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    public class Curso
    {
        public string Nombre { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public double nota4 { get; set; }
        public double promedio { get; set; }

        public abstract void calcularprom();
    }
}
