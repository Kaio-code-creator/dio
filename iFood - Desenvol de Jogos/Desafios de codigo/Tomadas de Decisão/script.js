// Solicita ao usuário que insira o nome do personagem:
const nomePersonagem = gets();

// Solicita ao usuário que escolha entre "Atacar" ou "Fugir":
const acaoEscolhida = gets();

// Verifica a ação escolhida e exibe a mensagem correspondente:
if (acaoEscolhida === "Atacar") {
  console.log(`${nomePersonagem} escolheu Atacar!`);
} else if (acaoEscolhida === "Fugir") {
  console.log(`${nomePersonagem} escolheu Fugir!`);
} else {
  console.log("Tente novamente");
}