// Função que calcula o saldo de Rankeadas e determina o nível
function calcularNivel(vitorias, derrotas) {
    const saldoVitorias = vitorias - derrotas;
    let nivel;

    if (vitorias < 10) {
        nivel = "Ferro";
    } else if (vitorias >= 11 && vitorias <= 20) {
        nivel = "Bronze";
    } else if (vitorias >= 21 && vitorias <= 50) {
        nivel = "Prata";
    } else if (vitorias >= 51 && vitorias <= 80) {
        nivel = "Ouro";
    } else if (vitorias >= 81 && vitorias <= 90) {
        nivel = "Diamante";
    } else if (vitorias >= 91 && vitorias <= 100) {
        nivel = "Lendário";
    } else {
        nivel = "Imortal";
    }

    return { saldoVitorias, nivel };
}

// Solicita ao usuário a quantidade de vitórias e derrotas
const vitoriasUsuario = parseInt(prompt("Digite a quantidade de vitórias: "));
const derrotasUsuario = parseInt(prompt("Digite a quantidade de derrotas: "));

// Validação de entrada
if (isNaN(vitoriasUsuario) || isNaN(derrotasUsuario)) {
    console.error("Por favor, insira números válidos para vitórias e derrotas.");
} else {
    // Chama a função e exibe o resultado
    const resultado = calcularNivel(vitoriasUsuario, derrotasUsuario);
    console.log(`O Herói tem um saldo de ${resultado.saldoVitorias} está no nível de ${resultado.nivel}`);
}