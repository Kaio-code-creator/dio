let nomeHeroi = prompt("Digite o nome do herói: ");
let xpHeroi = parseInt(prompt("Digite a quantidade de experiência do herói: "));

function calcularNivel(xp) {
    const niveis = [
        { limiteSuperior: 1000, nome: "Ferro" },
        { limiteSuperior: 2000, nome: "Bronze" },
        { limiteSuperior: 5000, nome: "Prata" },
        { limiteSuperior: 6000, nome: "Ouro" },
        { limiteSuperior: 7000, nome: "Platina" },
        { limiteSuperior: 8000, nome: "Ascendente" },
        { limiteSuperior: 9000, nome: "Imortal" },
        { limiteSuperior: Infinity, nome: "Radiante" }
    ];

    for (const nivel of niveis) {
        if (xp <= nivel.limiteSuperior) {
            return nivel.nome;
        }
    }
}

let nivel = calcularNivel(xpHeroi);

console.log(`O Herói de nome ${nomeHeroi} está no nível de ${nivel}`);