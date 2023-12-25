using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // Inicializa o array com base na quantidade informada pelo usuário:
        string[] nomesJogos = new string[quantidadeJogos];

        // Crei um Loop para adicionar jogos conforme a quantidade especificada:
        for (int i = 0; i < quantidadeJogos; i++)
        {
            // Chama a função AdicionarJogo para obter o nome do jogo do usuário e armazená-lo no array:
            AdicionarJogo(i.ToString(), nomesJogos);
        }

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(string indice, string[] nomesJogos)
    {
        // Verifica se o índice é um número inteiro
        if (!int.TryParse(indice, out int i))
        {
            // Exibe um erro se o índice não for um número inteiro
            Console.WriteLine("O índice deve ser um número inteiro.");
            return;
        }

        // Verifica se o índice está dentro do intervalo do array
        if (i < 0 || i >= nomesJogos.Length)
        {
            // Exibe um erro se o índice estiver fora do intervalo
            Console.WriteLine("O índice está fora do intervalo do array.");
            return;
        }

        // Entrada do nome do jogo
        nomesJogos[i] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomesJogos)
    {
        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomesJogos)} ao catalogo.");
    }
}
