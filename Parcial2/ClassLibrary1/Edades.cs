using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    public class Edades
    {
        public int edad;

        public void edades()
        {
            for (int i = 1; i <= 5;i++ )
            {
                Console.WriteLine("Digite la edad  del Alumno "+ i);
                edad = int.Parse(Console.ReadLine());

            }



        }

    }
}
