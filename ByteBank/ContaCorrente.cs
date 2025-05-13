
//criando uma classe pública chamada ContaCorrente

//using _05_ByteBank;

namespace _07_ByteBank
{


    public class ContaCorrente
    {
        //o titular agora não é mais uma string, mas sim uma referência de um objeto Cliente

        //private Cliente _titular;

        // construindo a Propriedade "Cliente"

        //public Cliente Titular 
        //{  
        //    get 
        //    { return _titular; 
        //    } 
        //    set
        //    {
        //        _titular = value;
        //    }

        //}

        //Simplificando ainda mais a Propriedade "Cliente"

        public Cliente Titular { get; set; }

        // 
        // Criando a propriedade TotalDeContasCriadas
        // a palavra "static" informa que essa é uma Propriedade que pertence à classe ContaCorrente, e não dos objetos criados
        public static int TotalDeContasCriadas {  get; private set; }



        // public int agencia;
        // public int numero;

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }

            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;

            }

        }


        public int Numero { get; set; }


        private double _saldo = 100;




        //// os métodos a seguir "DefinirSaldo" e "ObterSaldo" são um encapsulamento, pois manipulam um estado interno dentro da classe
        //// definindo o método "DefinirSaldo", do tipo "void"
        //public void DefinirSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        this._saldo = saldo;
        //    }
        //}


        //// definindo o método "ObterSaldo", do tipo "double"
        //public double ObterSaldo()
        //{
        //    return _saldo;
        //}


        // simplificando os métodos "DefinirSaldo" e "ObterSaldo"
        // construindo a Propriedade "Saldo"
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;

            }
        }

        // Construtor-01
        // informando que temos uma forma de se construir um objeto do tipo "ContaCorrente"
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            // incrementando e atribuindo um valor a essa Propriedade

            // Se utiliza "ContaCorrente." por ser o que a gente quer acessar, já que é uma característica da classe "ContaCorrente". 
            // Entretanto, como estamos dentro da classe e estamos manipulando um membro estático, isso se torna desnecessário.
            // Mas ficará no código como aprendizado, pra não confundir com "this.", que faz referência a objetos
            ContaCorrente.TotalDeContasCriadas++;
        }



        //criando a função (ou método) Sacar
        // bool representa um tipo que TEM retorno (true ou false)
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            //o "else" foi retirado dessa lógica para simplificação do código
            //else
            //{
            this._saldo -= valor;
            return true;
            //}
        }

        //criando o método (ou função) Depositar
        // void representa um tipo que NÃO tem retorno

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        //Criando o método Transferir
        //Representando no método vários argumentos do tipo ContaCorrente

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            //chamando o método Depositar já criado acima, passando como argumento o "valor" do método Tranferir, atuando no objeto "contaDestino"

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }


    }
}