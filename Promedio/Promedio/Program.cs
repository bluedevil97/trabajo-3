using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Curso c = new Curso();
            string Nombre = "";
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            double promedio= 0;
            

            Console.WriteLine("Nombre del Curso: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 4: ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            
            c.calcularprom();

    
            Console.ReadKey();

        }
    }
}
