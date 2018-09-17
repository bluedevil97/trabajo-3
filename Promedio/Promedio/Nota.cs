using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    public class Nota : Curso
    {
        public override void calcularprom()
        {
            promedio = (nota1 + nota2 + nota3 + nota4 / 4);
            
        }
    }
}
