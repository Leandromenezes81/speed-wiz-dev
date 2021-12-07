// Objetos

// Formato padrão de um objeto
var aluno1 = {
  matricula: 87652424,
  nome: "Leandro Menezes",
  curso: "Bootcamp Front End",
  ativo: true,
};

console.log(aluno1.nome);

// Criação dinâmica de um elemento do objeto

aluno1.dataNascimento = "22/04/1981";

console.log(aluno1.dataNascimento);

// Exclusão dinâmica de um elemento do objeto

delete aluno1.dataNascimento;

/* Quando o valor de uma variável em JavaScript não é determindado
esta recebe o valor de undefined */

var x;

/* Uma variável pode receber o valor null. Essa característica é
diferente de undefined*/

var y = null;

// Arrays

var frutas = ["Banana", "Laranja", "Maçã"];
