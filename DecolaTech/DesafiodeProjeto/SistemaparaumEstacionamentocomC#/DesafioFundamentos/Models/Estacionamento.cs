using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal PrecoInicial { get; private set; }
        public decimal PrecoPorHora { get; private set; }
        private List<VeiculoEstacionado> Veiculos { get; } = new List<VeiculoEstacionado>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void IniciarEstacionamento()
        {
            Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
            ObterPrecosIniciais();

            bool continuarExecucao = true;
            while (continuarExecucao)
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
                        continuarExecucao = false;
                        break;

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
            PrecoInicial = LerDecimalDoUsuario();

            Console.WriteLine("Agora digite o preço por hora:");
            PrecoPorHora = LerDecimalDoUsuario();
        }

        private void ExibirMenu()
        {
            Console.WriteLine("Digite a sua opção:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");
        }

        private static decimal LerDecimalDoUsuario()
        {
            decimal valor;
            while (true)
            {
                try
                {
                    valor = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, insira um valor válido.");
                }
            }
            return valor;
        }

        private static int LerInteiroDoUsuario()
        {
            int valor;
            while (true)
            {
                try
                {
                    valor = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, insira um valor válido.");
                }
            }
            return valor;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpperInvariant();
            if (ValidarPlaca(placa))
            {
                Veiculos.Add(new VeiculoEstacionado(placa, DateTime.Now));
                Console.WriteLine($"Veículo com a placa {placa} estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Certifique-se de inserir uma placa válida.");
            }
        }

        private static bool ValidarPlaca(string placa)
        {
            string pattern = @"^[A-Z]{3}-\d{4}$";
            return Regex.IsMatch(placa, pattern);
        }

        public void RemoverVeiculo()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Digite a placa do veículo que deseja remover:");
                string placaRemover = Console.ReadLine().ToUpperInvariant();

                var veiculo = Veiculos.FirstOrDefault(v => v.Placa == placaRemover);

                if (veiculo != null)
                {
                    decimal valorTotal = CalcularValorTotal(veiculo.HoraEntrada, DateTime.Now);

                    Veiculos.Remove(veiculo);

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

        private decimal CalcularValorTotal(DateTime horaEntrada, DateTime horaSaida)
        {
            TimeSpan duracao = horaSaida - horaEntrada;
            int horasEstacionado = (int)Math.Ceiling(duracao.TotalHours); // Arredonda para cima se houver minutos

            return PrecoInicial + PrecoPorHora * horasEstacionado;
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Veiculos.ForEach(veiculo => Console.WriteLine($"{veiculo.Placa} - Entrada: {veiculo.HoraEntrada}"));
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private class VeiculoEstacionado
        {
            public string Placa { get; }
            public DateTime HoraEntrada { get; }

            public VeiculoEstacionado(string placa, DateTime horaEntrada)
            {
                Placa = placa;
                HoraEntrada = horaEntrada;
            }
        }
    }
}