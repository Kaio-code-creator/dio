using System;

class Program
{
  static void Main(string[] args)
  {
    // Declara as variáveis para guardar as informações de nome, email e senha:
    string registroEmail;
    string registroNome;
    string registroSenha;

    // Obtém o email, nome e senha do usuário a partir da entrada do console
    registroEmail = Console.ReadLine();
    registroNome = Console.ReadLine();
    registroSenha = Console.ReadLine(); // Adicionei esta linha para ler a senha

    // Valida o e-mail
    if (!IsValidEmail(registroEmail))
    {
      Console.WriteLine("Shaula, verifique o email: shaula@email.com para ativar.");
      return;
    }

   

    // Tratamento da senha
    registroSenha = registroSenha.Trim();
    registroSenha = registroSenha.Replace(" ", "");

    // Imprime a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");
  }

  // Valida o e-mail
  private static bool IsValidEmail(string email)
  {
    // O e-mail deve conter o caractere @ e pelo menos um ponto.
    return email.Contains("@") && email.Contains(".");
  }
}
