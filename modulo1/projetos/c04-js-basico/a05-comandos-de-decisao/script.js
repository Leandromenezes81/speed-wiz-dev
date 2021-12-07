// Estrutura de decisão 'if/else' simples.

/*
function maior(a, b) {
  if (a > b) {
    return a;
  } else {
    return b;
  }
}*/

function maior(a, b, c) {
  if (a > b && a > c) {
    return a;
  } else if (b > a && b > c) {
    return b;
  } else {
    return c;
  }
}

// Operador Ternário '?'
function menor(a, b, c) {
  // var r = a < b ? a : b;
  var r = a < b && a < c ? a : b < a && b < c ? b : c;
  return r;
}

// Operador Switch.
function formataMes(mes) {
  switch (mes) {
    case 1:
      console.log("Janeiro");
      break;
    case 2:
      console.log("Fevereiro");
      break;
    case 3:
      console.log("Março");
      break;
    case 4:
      console.log("Abril");
      break;
    default:
      console.log("Sem implementação.");
  }
}
