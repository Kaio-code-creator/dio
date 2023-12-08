// Lê a jogada do personagem e do monstro
var jogadaPersonagem = parseInt(gets());
var jogadaMonstro = parseInt(gets());

// Verifica o resultado do combate e imprime o resultado
if (jogadaPersonagem > jogadaMonstro) {
  print("Você venceu a batalha!");
} else if (jogadaPersonagem < jogadaMonstro) {
  print("Você perdeu a batalha!");
} else {
  print("Foi um empate!");
}