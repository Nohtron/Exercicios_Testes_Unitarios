using System;
using System.Collections.Generic;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();

            Console.WriteLine("Sequencia de Fibonacci até o décimo número.");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(fibonacci.GetDezPrimeirosFibonnaci()[i].ToString());
            Console.WriteLine(" ");

            Console.WriteLine("Numero de Fibonnaci na posição 9.");
            Console.WriteLine(fibonacci.GetNumeroDeFibonacciNaPosicao(9));
            Console.WriteLine(" ");

            Console.WriteLine("Numero de Fibonnaci na posição 55.");
            Console.WriteLine(fibonacci.GetNumeroDeFibonacciNaPosicao(55));
            Console.WriteLine(" ");

            Console.WriteLine("Numero de Fibonnaci na posição 99.");
            Console.WriteLine(fibonacci.GetNumeroDeFibonacciNaPosicao(99));
            Console.ReadLine();
        }
    }

    public class Fibonacci
    {
        public Decimal GetPrimeiroNumeroFibonacci()
        {
            return 0;
        }

        public List<Decimal> GetDezPrimeirosFibonnaci()
        {
            List<Decimal> listaDezprimeirosFibonacci = new List<Decimal> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            return listaDezprimeirosFibonacci;
        }

        public List<Decimal> GetSequenciaDeFibonacciAte(Decimal maximo)
        {
            List<Decimal> sequenciaDeFibonacci = new List<Decimal>();

            if (maximo == 0)
                maximo = 1;

            for (int i = 1; i <= maximo; i++)
            {
                if (i <= 2)
                    sequenciaDeFibonacci.Add(1);
                else
                {
                    Decimal proximo = sequenciaDeFibonacci[i - 2] + sequenciaDeFibonacci[i - 3];
                    sequenciaDeFibonacci.Add(proximo);
                }
            }

            return sequenciaDeFibonacci;
        }

        public Decimal GetNumeroDeFibonacciNaPosicao(int n)
        {
            List<Decimal> sequenciaFibonacci = this.GetSequenciaDeFibonacciAte(n);

            if (n == 0)
                return sequenciaFibonacci[n];
            else
                return sequenciaFibonacci[n - 1];
        }
    }
}
