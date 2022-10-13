using SistemaEstacionamento.Models;

namespace SistemaEstacionamento
{
    public class Gerenciador
    {
        public static void Main(string[] args)
        {
            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

            estacionamento.AdicionarVeiculos();
            estacionamento.AdicionarVeiculos();
            estacionamento.ListarVeiculos();

            estacionamento.RemoverVeiculo();
            estacionamento.ListarVeiculos();
        }
    }
}