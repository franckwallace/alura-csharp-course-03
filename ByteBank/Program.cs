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
                ContaCorrente conta = new ContaCorrente(1234, 0);
            }

            catch (ArgumentException ex)  
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo 'ArgumentException'");
                Console.WriteLine(ex.Message);
            }

            //try
            //{
            //    Metodo();
            //}

            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção 'divisão por zero' tratada!");
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);

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
            try
            {
                return numero / divisor;
            }

            catch
            {
                Console.WriteLine("Exceção com o número '" + numero + "' e com o divisor '" + divisor + "'");
                throw;
            }


            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);


        }

    }
}
