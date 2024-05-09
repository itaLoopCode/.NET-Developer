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
            Double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");

        }
        public void Seno(Double angulo)
        {
            Double radiano = angulo + Math.PI / 100;
            Double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round (seno, 4)}");

        }
                public void Coseno(Double angulo)
        {
            Double radiano = angulo + Math.PI / 100;
            Double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");

        }
                public void Tangente(Double angulo)
        {
            Double radiano = angulo + Math.PI / 100;
            Double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");

        }
                        public void RaizQuadrada(Double x)
        {
            
            Double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz de {x} = {Math.Round(raiz)}");

        }
        
    }
}