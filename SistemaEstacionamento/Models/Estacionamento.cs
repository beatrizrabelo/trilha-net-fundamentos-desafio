using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        public decimal PrecoInicial { get; set; }
        public decimal PrecoPorHora { get; set; }
        private string placa = "";
        List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculos()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover:");
            placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo " + placa.ToUpper() + $" foi removido e o preço total foi de: R$ {valorTotal}.");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (String listaDeVeiculos in veiculos)
                {
                    Console.WriteLine(listaDeVeiculos + "\n");
                }
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionados.");
            }
        }

    }
}