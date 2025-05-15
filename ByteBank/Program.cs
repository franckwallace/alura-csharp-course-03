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

            //// nova forma de se construir um objeto, obedecendo o estabelecido no Construtor-01 na classe ContaCorrente
            //// ContaCorrente conta = new ContaCorrente(-263, 263105);


            //// Console.WriteLine(conta.Agencia);
            //// Console.WriteLine(conta.Numero);

            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //ContaCorrente contaDoBruno = new ContaCorrente(263, 263105);

            //Console.WriteLine(ContaCorrente.TaxaOperacao);

            ////Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ////ContaCorrente contaDaGabriela = new ContaCorrente(263, 263020);

            ////Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Metodo();

            Console.ReadLine();
        }

        // Teste com a cadeia em chamars;
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            //TestaDivisao(0);
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado );
        }

        private static int Dividir (int numero, int divisor)
        {
            return numero / divisor;
        }

    }
}
