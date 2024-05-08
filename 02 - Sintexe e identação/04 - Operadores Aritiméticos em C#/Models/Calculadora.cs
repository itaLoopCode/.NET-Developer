using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04___Operadores_Aritiméticos_em_C_.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");

        }
         public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");

        }

         public void Mutiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");

        }

         public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");

        }
        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {x ^ y}");

        }
    }
}