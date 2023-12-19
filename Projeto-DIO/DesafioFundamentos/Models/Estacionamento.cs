using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private Dictionary<string, DateTime> horariosEstacionamento = new Dictionary<string, DateTime>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Valida a placa
            if (!Regex.IsMatch(placa, "^([A-Z]{3}[0-9]{4})$"))
            {
                Console.WriteLine("A placa informada não é válida.");
                return;
            }

            // Verifica se a placa já está na lista
            if (veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("Este veículo já está estacionado. Tente novamente.");
            }
            else
            {
                // Adiciona a placa à lista de veículos e registra o horário de estacionamento
                veiculos.Add(placa.ToUpper());
                horariosEstacionamento.Add(placa.ToUpper(), DateTime.Now);
                Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Contains(placa.ToUpper()))
            {
                DateTime horaEstacionamento = horariosEstacionamento[placa.ToUpper()];

                Console.WriteLine($"O veículo {placa} está estacionado desde: {horaEstacionamento}");

                // Solicita o tempo estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (int.TryParse(Console.ReadLine(), out int horas) && horas >= 0)
                {
                    // Calcula o valor total a ser pago em reais
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    // Remove a placa e o horário de estacionamento da lista
                    veiculos.Remove(placa.ToUpper());
                    horariosEstacionamento.Remove(placa.ToUpper());

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:N2}");
                }
                else
                {
                    Console.WriteLine("Digite um valor válido para a quantidade de horas.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Loop de repetição para exibir os veículos
                foreach (var placa in veiculos)
                {
                    Console.WriteLine($"Veículo com placa {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}