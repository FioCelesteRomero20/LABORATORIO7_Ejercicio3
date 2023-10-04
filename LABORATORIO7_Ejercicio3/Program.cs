using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO7_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar datos
            int i;

            for (i = 1900; i <= 2023; i++)
            {
                if (i % 4 == 0)
                {
                    //Detectar años bisiestos
                    Console.WriteLine(i);
                    // numero = numero + i;
                }
            }
            Console.ReadKey();
        }
    }
}
