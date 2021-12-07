function simular2() {
  var valor = parseFloat(document.getElementById("valor").value);
  var prazoAnos = document.getElementById("prazoanos").valueAsNumber;
  var jurosAa = document.getElementById("jurosaa").valueAsNumber;
  var prazoMeses = prazoAnos * 12;

  var jurosAm = Math.pow(1 + jurosAa, 1 / 12) - 1;
  var amortizacao = valor / prazoMeses;

  document.getElementById("prazomeses").valueAsNumber = prazoMeses;
  document.getElementById("jurosam").valueAsNumber = jurosAm;

  var jurosTotal = 0;
  var tbody = document.querySelector("tbody");

  for (var i = 0; i < prazoMeses; i++) {
    var saldoDevedor = valor - i * amortizacao;
    var jurosPrestacao = saldoDevedor * jurosAm;
    jurosTotal += jurosPrestacao;
    var totalPrestacao = jurosPrestacao + amortizacao;
    if (i < 5) {
      var tr = tbody.children[i];
      tr.children[1].textContent = amortizacao.toFixed(2);
      tr.children[2].textContent = jurosPrestacao.toFixed(2);
      tr.children[3].textContent = totalPrestacao.toFixed(2);
    }
  }

  document.getElementById("jurostotal").valueAsNumber = jurosTotal.toFixed(2);
}

function simular() {
  var valor = parseFloat(document.getElementById("valor").value);
  var prazoAnos = document.getElementById("prazoanos").valueAsNumber;
  var jurosAa = document.getElementById("jurosaa").valueAsNumber;
  var prazoMeses = prazoAnos * 12;

  var jurosAm = Math.pow(1 + jurosAa, 1 / 12) - 1;
  var amortizacao = valor / prazoMeses;

  document.getElementById("prazomeses").valueAsNumber = prazoMeses;
  document.getElementById("jurosam").valueAsNumber = jurosAm;

  var jurosTotal = 0;
  var tbody = document.querySelector("tbody");
  tbody.innerHTML = "";

  for (var i = 0; i < prazoMeses; i++) {
    var saldoDevedor = valor - i * amortizacao;
    var jurosPrestacao = saldoDevedor * jurosAm;
    jurosTotal += jurosPrestacao;
    var totalPrestacao = jurosPrestacao + amortizacao;

    var tr = document.createElement("tr");
    var td0 = criaTd(i + 1);
    var td1 = criaTd(amortizacao.toFixed(2));
    var td2 = criaTd(jurosPrestacao.toFixed(2));
    var td3 = criaTd(totalPrestacao.toFixed(2));
    tr.append(td0, td1, td2, td3);
    tbody.append(tr);
  }

  document.getElementById("jurostotal").valueAsNumber = jurosTotal.toFixed(2);
}

function criaTd(texto) {
  var td = document.createElement("td");
  td.textContent = texto;
  return td;
}

simular();
