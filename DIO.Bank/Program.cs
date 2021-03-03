using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Marcus Oliveira");
            Console.WriteLine(minhaConta.ToString());
            
        }
    }
}
