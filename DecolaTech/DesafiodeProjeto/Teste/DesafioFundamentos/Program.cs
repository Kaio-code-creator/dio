using DesafioFundamentos.Models;

using System;

class Program
{
    static void Main()
    {
        int quantidadeJogos;

        while (!int.TryParse(Console.ReadLine(), out quantidadeJogos) || quantidadeJogos <= 0);

        string[] nomesJogos = new string[quantidadeJogos];

        for (int i = 0; i < quantidadeJogos; i++)
        {
            nomesJogos[i] = GerarNomeJogo(i);
        }

        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomesJogos)} ao catalogo.");
    }

    static string GerarNomeJogo(int numeroJogo)
    {
        // Lista de nomes de jogos predefinidos
        string[] nomes = { "Portal", "Limbo", "Tetris", "Doom", "Pong", "FIFA" };

        // Garante que o índice está dentro dos limites da lista de nomes
        int indice = numeroJogo % nomes.Length;

        return nomes[indice];
    }
}