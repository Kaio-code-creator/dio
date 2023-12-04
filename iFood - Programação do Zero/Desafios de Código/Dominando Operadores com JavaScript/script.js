// Desafios JavaScript na DIO têm funções "gets" e "print" acessíveis globalmente:
// - "gets": lê UMA linha com dado(s) de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output), pulando linha.

// Para converter os valores inseridos na entrada, utilizamos a função JavaScript parseInt() que converte a parte inicial da string em um número inteiro.
const nivelMonstro = parseInt(gets());
const dificuldadeBatalha = parseInt(gets());

// Calcula a quantidade de XP ganhos
const xpGanho = nivelMonstro * dificuldadeBatalha * 100;

// Imprime a mensagem com a quantidade de XP ganhos usando interpolação de strings
print(`Voce ganhou ${xpGanho} XP!`);
