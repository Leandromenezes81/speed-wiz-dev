using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca.InputModel
{
    public class AtualizarLeitorInput
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
