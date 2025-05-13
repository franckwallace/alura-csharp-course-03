using _07_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nova forma de se construir um objeto, obedecendo o estabelecido no Construtor-01 na classe ContaCorrente
            // ContaCorrente conta = new ContaCorrente(-263, 263105);


            // Console.WriteLine(conta.Agencia);
            // Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaDoBruno = new ContaCorrente(263, 263105);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaDaGabriela = new ContaCorrente(263, 263020);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
