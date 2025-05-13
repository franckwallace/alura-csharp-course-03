using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        // public string nome;
        // public string cpf;
        // public string profissao;

        private string _cpf;

        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                //Aqui escreve-se a lógica de validação de CPF, caso necessária

                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
