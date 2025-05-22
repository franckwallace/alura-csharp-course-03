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

            catch (System.NullReferenceException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);

                Console.WriteLine("Exceção tratada!");

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
            try
            {
                Dividir(10, divisor);


            }


            catch (System.DivideByZeroException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);

                Console.WriteLine("Exceção tratada!");
            }

            // int resultado = Dividir(10, divisor);

            // Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado );
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);


            return numero / divisor;
        }

    }
}
