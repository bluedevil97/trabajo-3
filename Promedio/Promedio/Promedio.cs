using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    public class Promedio
    {
        public List<Curso> curso { get; set; }

        public void calcularprom()
        {
            foreach (var dato in curso)
            {
                dato.calcularprom();
            }
        }
    }
}
