// Capturando os elementos com id = 'n1' e 'n2'.
var n1 = document.getElementById("n1");
var n2 = document.getElementById("n2");
var r = document.getElementById("r");
function calcula() {
  // '.valueAsNumber' = converte a String em número.
  var resultado = n1.valueAsNumber + n2.valueAsNumber;
  /* Caso os valores inseridos em 'n1' e 'n2' não sejam
  números, o valor de 'r' será pagado. */
  if (isNaN(resultado)) {
    r.textContent = "";
  } else {
    r.textContent = resultado;
  }
  /* textContent é uma propriedade HTM que retorna o
  conteúdo textual do elemento.  Essa propriedade, além
  de retornar o conteúdo, também pode alterá-lo. Nesse caso,
  o conteúdo do 'span' com 'id = r' recebeu o valor da
  variável 'resultado'. */
}
