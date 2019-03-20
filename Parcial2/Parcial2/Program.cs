using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Parcial2
{
    class Program
    {

        Dividir obj2 = new Dividir();
        Edades obj4 = new Edades();
        Multiplicar obj1 = new Multiplicar();
        Nombres obj3 = new Nombres();

        
        
        static void Main(string[] args)
        {
             int numc1;
            Console.WriteLine("Digite la opcion que desea 1 para multiplicar ,  2 para Dividir, 3 Para 5 Nombres y 4 para 5 Edades");
            Program.numc1 = int.Parse(Console.ReadLine());

            if (numc1 >= 1)
            {
                Console.WriteLine("La opcion elegida es la Multiplicacion");
               

            }


        }
    }
}
