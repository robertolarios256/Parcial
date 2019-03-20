using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
   public class Dividir
    {

        public int num1,num2,result;

        public void Divi()
        {
            Console.WriteLine("Porfavor digite el primer numero entero");
            num1 = int.Parse(Console.ReadLine());


            if (num1 <= 0)
            {


                Console.WriteLine("Digite el segundo valor entero");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;

                Console.WriteLine("El Resultado es : " + result);

            }
            else if (num2 <= 0)
            {
                Console.WriteLine("Error: no se puede dividir entre cero");

            }
        }
    }
}
