// Desafios JavaScript na DIO têm funções "gets" e "print" acessíveis globalmente:
// - "gets": lê UMA linha com dado(s) de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output), pulando linha.

// Solicita ao treinador que escolha seu Pokémon
const escolhaPokemon = parseInt(gets("Escolha o seu Pokemon: "));

// Verifica a escolha e exibe a mensagem correspondente
switch (escolhaPokemon) {
  case 1:
    print("Voce escolheu o Bulbasaur como seu Pokemon inicial.");
    break;
  case 2:
    print("Voce escolheu o Charmander como seu Pokemon inicial.");
    break;
  case 4:
    print("Voce escolheu o Pikachu como seu Pokemon inicial.");
    break;
  case 5:
    print("Voce escolheu o Mewtwo como seu Pokemon inicial.");
    break;
  default:
    print("Escolha inválida. Por favor, escolha 1 para Bulbasaur, 2 para Charmander, 4 para Pikachu ou 5 para Mewtwo.");
}