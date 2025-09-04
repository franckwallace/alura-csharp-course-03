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
                ContaCorrente conta = new ContaCorrente(1234, 645678);
                ContaCorrente conta2 = new ContaCorrente(0001, 999988);

                conta2.Transferir(-8888, conta);

                conta.Depositar(13);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(10);
                Console.WriteLine(conta.Saldo);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo 'ArgumentException'");
                Console.WriteLine(ex.Message);
            }

            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo 'SaldoInsuficienteException'");
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
