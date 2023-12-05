const totalSalas = parseInt(gets());

const salasComTesouro = [2, 4, 7];
const salasComMonstro = [3, 6, 8];

for (let sala = 1; sala <= totalSalas; sala++) {
    const temTesouro = salasComTesouro.includes(sala);
    const temMonstro = salasComMonstro.includes(sala);

    if (temTesouro) {
        print(`Tesouro na sala ${sala}!`);
    } else if (temMonstro) {
        print(`Monstro na sala ${sala}!`);
    }
}