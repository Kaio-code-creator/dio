using System;
using VeiculoList;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        protected List<Veiculo> Veiculos { get; set; }

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            Veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo()
        {
            var veiculo = new Veiculo();

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculo.Placa = Console.ReadLine();
            veiculo.Placa = veiculo.Placa.ToUpper();

            Veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            if (Veiculos.Any(x => x.Placa == placa.ToUpper()))
            {
                
                Console.WriteLine("Quantas horas o veículo passou estacionado?");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;


                foreach (var item in Veiculos)
                {
                    Veiculos.Remove(item);
                    break;
                }

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in Veiculos)
                {
                    item.List();
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.\n");
            }
        }
    }
}

