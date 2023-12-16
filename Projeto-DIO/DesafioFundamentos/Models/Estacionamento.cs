namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para estacionar:");
    string placa = Console.ReadLine();

    // Verifica se a placa já está na lista
    if (veiculos.Contains(placa.ToUpper()))
    {
        Console.WriteLine("Este veículo já está estacionado. Tente novamente.");
    }
    else
    {
        // Adiciona a placa à lista de veículos
        veiculos.Add(placa.ToUpper());
        Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
    }
}

        public void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para remover:");
    string placa = Console.ReadLine();

    // Verifica se o veículo existe
    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        if (int.TryParse(Console.ReadLine(), out int horas))
        {
            // Calcula o valor total a ser pago
            decimal valorTotal = precoInicial + precoPorHora * horas;

            // Remove a placa digitada da lista de veículos
            veiculos.Remove(placa.ToUpper());

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
