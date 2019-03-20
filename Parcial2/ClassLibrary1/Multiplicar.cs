using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    public class Multiplicar
    {
        public int num1,num2;
        public int result;

        public void Multi()
        {
            Console.WriteLine("Porfavor digite el primer numero entero");
            num1 = int.Parse(Console.ReadLine());
            if(num1<=0){

                Console.WriteLine("el producto de 0 por cualquier numero es 0");

            }else if(num1>=0){

                Console.WriteLine("Digite el segundo valor entero");
                num2 = int.Parse(Console.ReadLine());
                result = num1 * num2;

                Console.WriteLine("El Resultado es : "+result);
            }

            Console.ReadKey();
        }


    }
}
