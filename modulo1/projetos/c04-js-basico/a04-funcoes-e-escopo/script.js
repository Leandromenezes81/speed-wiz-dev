// Variável de escopo global.
var m = "Olá";
imprimeOla();
//imprimeOla2();

// Sintaxe para declaração de funções.
function imprimeOla() {
  // Variável de escopo local.
  var nome = "Leandro";
  console.log(m);
  console.log(nome);
}

/*
function imprimeOla2() {
  // Esse tipo de declaração retornará erro. Variável 'm' declarada em outra função.
  console.log(m);
  console.log(nome);
}
*/

// Sintaxe para declaração de funções passando parâmetros para as variáveis.
function soma(op1, op2) {
  return op1 + op2;
}
