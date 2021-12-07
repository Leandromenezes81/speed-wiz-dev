palindromo("aba"); // É palíndromo
palindromo("radar"); // É palíndromo
palindromo("zyzzyx"); // É palíndromo
palindromo("bola");
palindromo("abcddcb"); // Não é palíndromo
palindromo(""); // É palíndromo
palindromo("x"); // É palíndromo
palindromo("hora"); // Não é palíndromo

function palindromo(s) {
  /*
  Implementar
  s.length => tamanho da String passada como parâmetro de "s"
  Esta estrutura avalia identifica String com 1 ou 0 caractere.
  if (s.length <= 1) {
    console.log(s + " é palíndromo.");
    return;
  } */

  for (var i = 0, j = s.length - 1; i < j; i++, j--) {
    if (s.charAt(i) != s.charAt(j)) {
      console.log(s + " não é palíndromo.");
      return;
    }
  }
  console.log(s + " é palíndromo.");
}
