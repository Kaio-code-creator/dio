using System;

namespace AdicionarPlacaVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista para armazenar as placas de veículos
            List<string> placas = new List<string>();

            // Loop para solicitar a placa de veículos
            while (true)
            {
                // Solicita a placa do veículo
                Console.WriteLine("Digite a placa do veículo:");
                string placa = Console.ReadLine();

                // Verifica se a placa já foi registrada
                if (!placas.Contains(placa))
                {
                    // Adiciona a placa à lista
                    placas.Add(placa);

                    // Solicita o valor da entrada
                    Console.WriteLine("Digite o valor da entrada:");
                    double valorEntrada = double.Parse(Console.ReadLine());

                    // Solicita o valor por hora
                    Console.WriteLine("Digite o valor por hora:");
                    double valorHora = double.Parse(Console.ReadLine());

                    // Imprime a placa registrada
                    Console.WriteLine("Placa registrada: {0}", placa);
                    Console.WriteLine("Valor da entrada: {0}", valorEntrada);
                    Console.WriteLine("Valor por hora: {0}", valorHora);
                }
                else
                {
                    // Informa que a placa já foi registrada
                    Console.WriteLine("Placa já registrada.");
                }

                // Solicita se deseja continuar
                Console.WriteLine("Deseja continuar? (S/N):");
                string resposta = Console.ReadLine();

                // Se a resposta for "N", termina o loop
                if (resposta.ToUpper() == "N")
                {
                    break;
                }
            }
        }
    }
}
