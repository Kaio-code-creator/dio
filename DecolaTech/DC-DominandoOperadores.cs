using System;

class Program
{
    static void Main()
    {
        // Declara as variáveis para guardar as informações da tarefa:
        string titulo;
        string descricao;
        string dataVencimento;

        // Obtém o título, a descrição e a data de vencimento a partir da entrada do console
        try
        {
            titulo = Console.ReadLine();
            descricao = Console.ReadLine();
            dataVencimento = Console.ReadLine();
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("Descricao ou data de vencimento invalida.");
            return;
        }

        // Verifica se a descrição excede 50 caracteres
        if (descricao.Length > 50)
        {
            // Se sim, imprime uma mensagem de erro
            Console.WriteLine("Descricao ultrapassa limite de caracteres.");
            return;
        }

        // Caso a descrição esteja dentro do limite, imprime a tarefa com a data de vencimento
        Console.WriteLine($"Título: {titulo} | Descrição: {descricao} | Data de vencimento: {dataVencimento}");
    }
}
