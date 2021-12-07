using System;
using System.Collections;
using System.Collections.Generic;

namespace ExercicioBiblioteca.Models
{
    // Classe responsável por criar o modelo da tabela 'emprestimo'.
    public class Emprestimo
    {
        public int Numero { get; set; }
        public Leitor Leitor { get; set; }
        public int CodigoLeitor { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        // Propriedade criada para listar os itens do empréstimo no empréstimo.
        public ICollection<ItensEmprestimo> Itens { get; set; }
    }
}
