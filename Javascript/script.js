function calcularSituacao(media) {
    if (media < 5) {
      return "REP";
    } else if (media >= 5 && media < 7) {
      return "REC";
    } else {
      return "APR";
    }
  }
  
  let media = gets();
  
  console.log(calcularSituacao(media));