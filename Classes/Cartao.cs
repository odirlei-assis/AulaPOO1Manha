using System;

namespace ExemploPOO1.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do seu cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite a numeração do seu cartão");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do seu cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o CVV do seu cartão");
            Cvv = Console.ReadLine();

            return $"Cartão de numero {Numero} salvo com sucesso!";
        }
    }
}