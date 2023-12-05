const quantidadeGolpes = parseInt(gets());

const minerais = ["Carvao", "Ferro", "Diamante", "Pedra"];

for (let i = 1; i <= quantidadeGolpes; i++) {
  const minaIndex = (i - 1) % minerais.length;
  print(`${i}: ${minerais[minaIndex]}`);
}