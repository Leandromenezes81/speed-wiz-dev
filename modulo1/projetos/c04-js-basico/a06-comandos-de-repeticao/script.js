// Estrutura de Repetição - while

console.log("Imprimindo números de 1 a 5 com 'while'");

// Iniciando o contador.
var contador1 = 1;

while (contador1 <= 5) {
  console.log(contador1);

  // Incrementando contador (Retorna -> Incrementa)
  contador1++;
}

// Estrutura de Repetição - do while

console.log("Imprimindo números de 1 a 5 com 'do while'");

// Iniciando o contador.
var contador2 = 1;

do {
  console.log(contador2);

  // Incrementando contador (Retorna -> Incrementa)
  contador2++;
} while (contador2 <= 5);

// Estrutura de Repetição - for

console.log("Imprimindo números de 1 a 5 com 'for', numa estrutura simples.");
// Estrutura Simples
// for (início-contador, condição, incremento-contador)
for (var contador3 = 1; contador3 <= 5; contador3++) {
  console.log(contador3);
}

// Estrutura incrementada
// for (início-contador, condição, incremento-contador)

// Variável sendo declarada fora da estrutura for

var contador4 = 1;

console.log(
  "Imprimindo números de 1 a 5 com 'for', numa estrutura com 'break'."
);
for (; contador4 <= 5; contador4++) {
  console.log(contador4);
  //Execeuta a primeira repetição e para o for
  break;
}

var contador5 = 1;

console.log(
  "Imprimindo números de 1 a 5 com 'for', numa estrutura com 'continue'."
);
for (; contador5 <= 5; contador5++) {
  // Se contador 5 for exatamente igual a 3, pula essa repetição e continua as próximas.
  if (contador5 === 3) {
    continue;
  }
  console.log(contador5);
}
