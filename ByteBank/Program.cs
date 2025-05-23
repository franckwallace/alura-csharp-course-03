using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Metodo();
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção 'divisão por zero' tratada!");
            }


            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                //Console.WriteLine(erro.StackTrace);

                Console.WriteLine("Exceção genérica tratada!");

            }

            Console.ReadLine();

        }

        // Teste com a cadeia em chamars;
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {

            Dividir(10, divisor);


        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }

    }
}
