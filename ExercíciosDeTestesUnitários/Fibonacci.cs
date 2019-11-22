using System;
using System.Collections.Generic;

namespace ExercíciosDeTestesUnitários
{
    public class Fibonacci
    {
        public int GetPrimeiroNumeroFibonacci()
        {
            return 0;
        }

        public List<int> GetDezPrimeirosFibonnaci()
        {
            List<int> listaDezprimeirosFibonacci = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            return listaDezprimeirosFibonacci;
        } 

        public List<int> GetSequenciaDeFibonacciAte(int maximo)
        {
            List<int> sequenciaDeFibonacci = new List<int>();

            if (maximo == 0)
                maximo = 1;

            for (int i = 1; i<= maximo; i++)
            {
                if (i <= 2)
                    sequenciaDeFibonacci.Add(1);
                else
                {
                    int proximo = sequenciaDeFibonacci[i - 2] + sequenciaDeFibonacci[i - 3];
                    sequenciaDeFibonacci.Add(proximo);
                }     
            }

            return sequenciaDeFibonacci;
        }

        public int GetNumeroDeFibonacciNaPosicao(int n)
        {
            List<int> sequenciaFibonacci = this.GetSequenciaDeFibonacciAte(n);

            if (n == 0)
                return sequenciaFibonacci[n];
            else
                return sequenciaFibonacci[n - 1];
        }
    }
}
