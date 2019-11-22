using ExercíciosDeTestesUnitários;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestesUnitários
{
    [TestClass]
    public class FibonacciTestes
    {
        [TestMethod]
        public void TestGetPrimeiroNumeroFibonacci()
        {
            // Preparação
            Fibonacci fibonacci = new Fibonacci();
            int saidaEsperada = 0;

            // Ação
            int saida = fibonacci.GetPrimeiroNumeroFibonacci();

            // Verificação
            Assert.AreEqual(saidaEsperada, saida);
        }


        [TestMethod]
        public void TestGetDezPrimeirosFibonacci()
        {
            // Preparação
            Fibonacci fibonacci = new Fibonacci();
            List<int> saidaEsperada = new List<int>{ 1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            // Ação
            List<int> saida = fibonacci.GetDezPrimeirosFibonnaci();

            // Verificação
            for (int i = 0 ; i < 10; i++) 
            {
                Assert.AreEqual(saidaEsperada[i], saida[i]); 
            }
            
        }

        [TestMethod]
        public void TestGetSequenciaDeFibonacciAte10()
        {
            // Preparação
            Fibonacci fibonacci = new Fibonacci();
            List<int> saidaEsperada = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            // Ação
            //List<int> saida0 = fibonacci.GetSequenciaDeFibonacciAte(0);
            //List<int> saida1 = fibonacci.GetSequenciaDeFibonacciAte(1);
            //List<int> saida2 = fibonacci.GetSequenciaDeFibonacciAte(2);
            //List<int> saida3 = fibonacci.GetSequenciaDeFibonacciAte(3);
            //List<int> saida4 = fibonacci.GetSequenciaDeFibonacciAte(4);
            //List<int> saida5 = fibonacci.GetSequenciaDeFibonacciAte(5);
            //List<int> saida6 = fibonacci.GetSequenciaDeFibonacciAte(6);
            //List<int> saida7 = fibonacci.GetSequenciaDeFibonacciAte(7);
            //List<int> saida8 = fibonacci.GetSequenciaDeFibonacciAte(8);
            //List<int> saida9 = fibonacci.GetSequenciaDeFibonacciAte(9);
            List<int> saida = fibonacci.GetSequenciaDeFibonacciAte(10);


            // Verificação
            CollectionAssert.AreEqual(saidaEsperada, saida);

        }

        [TestMethod]
        public void TestGetSequenciaDeFibonacciAteNsValoresPositivos()
        {
            // Preparação
            Fibonacci fibonacci = new Fibonacci();
            List<List<int>> saidasEsperadas = new List<List<int>> {
            new List<int> { 1 },
            new List<int> { 1 },
            new List<int> { 1, 1 },
            new List<int> { 1, 1, 2 },
            new List<int> { 1, 1, 2, 3 },
            new List<int> { 1, 1, 2, 3, 5 },
            new List<int> { 1, 1, 2, 3, 5, 8 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 },
            new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 }
            };

            // Ação
            List<List<int>> saidas = new List<List<int>> {
                fibonacci.GetSequenciaDeFibonacciAte(0),
                fibonacci.GetSequenciaDeFibonacciAte(1),
                fibonacci.GetSequenciaDeFibonacciAte(2),
                fibonacci.GetSequenciaDeFibonacciAte(3),
                fibonacci.GetSequenciaDeFibonacciAte(4),
                fibonacci.GetSequenciaDeFibonacciAte(5),
                fibonacci.GetSequenciaDeFibonacciAte(6),
                fibonacci.GetSequenciaDeFibonacciAte(7),
                fibonacci.GetSequenciaDeFibonacciAte(8),
                fibonacci.GetSequenciaDeFibonacciAte(9),
                fibonacci.GetSequenciaDeFibonacciAte(10),
                fibonacci.GetSequenciaDeFibonacciAte(11),
                fibonacci.GetSequenciaDeFibonacciAte(12),
                fibonacci.GetSequenciaDeFibonacciAte(13),
                fibonacci.GetSequenciaDeFibonacciAte(14),
                fibonacci.GetSequenciaDeFibonacciAte(15),
                fibonacci.GetSequenciaDeFibonacciAte(16),
                fibonacci.GetSequenciaDeFibonacciAte(17),
                fibonacci.GetSequenciaDeFibonacciAte(18),
                fibonacci.GetSequenciaDeFibonacciAte(19),
                fibonacci.GetSequenciaDeFibonacciAte(20)
            };

            // Verificação
            CollectionAssert.AreEqual(saidasEsperadas[0], saidas[0]);
            CollectionAssert.AreEqual(saidasEsperadas[1], saidas[1]);
            CollectionAssert.AreEqual(saidasEsperadas[2], saidas[2]);
            CollectionAssert.AreEqual(saidasEsperadas[3], saidas[3]);
            CollectionAssert.AreEqual(saidasEsperadas[4], saidas[4]);
            CollectionAssert.AreEqual(saidasEsperadas[5], saidas[5]);
            CollectionAssert.AreEqual(saidasEsperadas[6], saidas[6]);
            CollectionAssert.AreEqual(saidasEsperadas[7], saidas[7]);
            CollectionAssert.AreEqual(saidasEsperadas[8], saidas[8]);
            CollectionAssert.AreEqual(saidasEsperadas[9], saidas[9]);
            CollectionAssert.AreEqual(saidasEsperadas[10], saidas[10]);
            CollectionAssert.AreEqual(saidasEsperadas[11], saidas[11]);
            CollectionAssert.AreEqual(saidasEsperadas[12], saidas[12]);
            CollectionAssert.AreEqual(saidasEsperadas[13], saidas[13]);
            CollectionAssert.AreEqual(saidasEsperadas[14], saidas[14]);
            CollectionAssert.AreEqual(saidasEsperadas[15], saidas[15]);
            CollectionAssert.AreEqual(saidasEsperadas[16], saidas[16]);
            CollectionAssert.AreEqual(saidasEsperadas[17], saidas[17]);
            CollectionAssert.AreEqual(saidasEsperadas[18], saidas[18]);
            CollectionAssert.AreEqual(saidasEsperadas[19], saidas[19]);
            CollectionAssert.AreEqual(saidasEsperadas[20], saidas[20]);

        }

        [TestMethod]
        public void TestGetNumeroDeFibonacciNaPosicaoZero()
        {
            // Preparação
            Fibonacci fibonacci = new Fibonacci();
            int saidaEsperada = 1;

            // Ação
            int saida = fibonacci.GetNumeroDeFibonacciNaPosicao(0);

            // Verificação
            Assert.AreEqual(saidaEsperada, saida);
        }

        [TestMethod]
        public void TestGetNumeroDeFibonacciNaPosicaoUm()
        {
            // Preparação
            Fibonacci fibonacci = new Fibonacci();
            int saidaEsperada = 1;

            // Ação
            int saida = fibonacci.GetNumeroDeFibonacciNaPosicao(1);

            // Verificação
            Assert.AreEqual(saidaEsperada, saida);
        }

        [TestMethod]
        public void TestNumeroDeFibonacciNasPosicaoDeUmAteDez()
        {
            // Preparação
            Fibonacci fibonacci = new Fibonacci();
            List<int> saidasEsperadas = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };


            // Ação
            List<int> saidas = new List<int>
            {
                fibonacci.GetNumeroDeFibonacciNaPosicao(1),
                fibonacci.GetNumeroDeFibonacciNaPosicao(2),
                fibonacci.GetNumeroDeFibonacciNaPosicao(3),
                fibonacci.GetNumeroDeFibonacciNaPosicao(4),
                fibonacci.GetNumeroDeFibonacciNaPosicao(5),
                fibonacci.GetNumeroDeFibonacciNaPosicao(6),
                fibonacci.GetNumeroDeFibonacciNaPosicao(7),
                fibonacci.GetNumeroDeFibonacciNaPosicao(8),
                fibonacci.GetNumeroDeFibonacciNaPosicao(9),
                fibonacci.GetNumeroDeFibonacciNaPosicao(10)
            };

            // Verificação
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(saidasEsperadas[i], saidas[i]);
            }
        }
    }
}
