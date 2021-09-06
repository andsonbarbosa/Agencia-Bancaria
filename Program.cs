using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Endereco endereco = new Endereco("Rua test", "12312313", "Recife", "PE");
                Cliente cliente = new Cliente("andson","1234567","123123123", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta "+ conta.Situacao +": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc123123123";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Secar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
