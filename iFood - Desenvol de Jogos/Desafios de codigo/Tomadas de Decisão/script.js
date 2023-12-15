// Solicita ao usuário que insira o nome do personagem:
const nomePersonagem = gets();

// Solicita ao usuário que escolha entre "Atacar" ou "Fugir":
const acaoEscolhida = gets();

// Verifica a ação escolhida e exibir a mensagem correspondente:
while (acaoEscolhida !== "Atacar" && acaoEscolhida !== "Fugir") {
    console.log("Tente novamente");
    acaoEscolhida = gets();
}

// Exibe a mensagem correspondente:
console.log(`${nomePersonagem} escolheu ${acaoEscolhida}!`);