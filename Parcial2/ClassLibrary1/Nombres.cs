using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
     public class Nombres
    {
        public String nom;
        
        public void nombres(){


            for (int x = 1; x >= 5;x++ )
            {

                Console.WriteLine("Digite el nombre de el Alumno "+x);
                nom = Console.ReadLine();

            }

            Console.ReadKey();
        }

    }
}
