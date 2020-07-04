using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionACSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            decimal b = 10101010.10101010101010101010101010101010101010101010101010m;

            b = b * b;

            Console.WriteLine(b);

            Console.WriteLine("Escriba un número: "); //Esto imprime un mensaje
            a = int.Parse(Console.ReadLine());


            
            if (a<5)
            {
                mensajeA();
            }

            else
            {
                mensajeB();
            } 

            
        }


        static void mensajeA()
        {
            Console.WriteLine("El número es menor que 5");
        }

        static void mensajeB()
        {
            Console.WriteLine("El número es mayor que 5");
        }
    }
}
