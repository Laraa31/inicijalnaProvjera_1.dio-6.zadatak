using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalnaProvjera_1.dio_6.zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brClanova;
            double suma=0;

            Console.WriteLine("Unesi broj članova reda: ");
            brClanova =Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < brClanova; i++)
            {
                suma = suma+1 / (3 * i);
            }

            Console.WriteLine(suma);
            Console.ReadKey();

        }
    }
}
