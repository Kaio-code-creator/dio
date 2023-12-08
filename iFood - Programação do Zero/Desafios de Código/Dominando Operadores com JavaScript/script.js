const nivelMonstro = parseInt(gets());
const dificuldadeBatalha = parseInt(gets());

// Calcula a quantidade de XP ganhos
const xpGanho = nivelMonstro * dificuldadeBatalha * 100;

// Imprime a mensagem com a quantidade de XP ganhos usando interpolação de strings
print(`Voce ganhou ${xpGanho} XP!`);
