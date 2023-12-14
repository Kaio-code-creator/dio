using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void IniciarEstacionamento()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
            ObterPrecosIniciais();

            while (true)
            {
                Console.Clear();
                ExibirMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        AdicionarVeiculo();
                        break;

                    case "2":
                        RemoverVeiculo();
                        break;

                    case "3":
                        ListarVeiculos();
                        break;

                    case "4":
                        Console.WriteLine("O programa se encerrou");
                        return;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
        }

        private void ObterPrecosIniciais()
        {
            Console.WriteLine("Digite o preço inicial:");
            precoInicial = LerDecimalDoUsuario();

            Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = LerDecimalDoUsuario();
        }

        private void ExibirMenu()
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
        }

        private decimal LerDecimalDoUsuario()
        {
            decimal valor;
            while (!decimal.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }
            return valor;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Validar a placa antes de adicionar ao estacionamento
            string placa = Console.ReadLine().ToUpperInvariant();
            if (ValidarPlaca(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com a placa {placa} estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Certifique-se de inserir uma placa válida.");
            }
        }

         private bool ValidarPlaca(string placa)
        {
            // Validar placa automotiva no formato "ABC1D23"
            // "ABC" são letras e "1D23" são números
            string pattern = @"^[A-Z]{3}-\d{4}$";
            return Regex.IsMatch(placa, pattern);
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Digite a placa do veículo que deseja remover:");
                string placaRemover = Console.ReadLine().ToUpperInvariant();

                if (veiculos.Contains(placaRemover))
                {
                    Console.WriteLine($"Digite a quantidade de horas que o veículo {placaRemover} permaneceu estacionado:");
                    int horas = LerInteiroDoUsuario();
                    decimal valorTotal = CalcularValorTotal(horas);

                    veiculos.Remove(placaRemover);

                    Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine($"Desculpe, o veículo com a placa {placaRemover} não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private int LerInteiroDoUsuario()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }
            return valor;
        }

        private decimal CalcularValorTotal(int horas)
        {
            return precoInicial + precoPorHora * horas;
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                veiculos.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}