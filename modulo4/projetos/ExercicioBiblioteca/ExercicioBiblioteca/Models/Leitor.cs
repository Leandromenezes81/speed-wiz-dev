namespace ExercicioBiblioteca.Models
{
    // Classe responsável por criar o modelo da tabela 'leitor'.
    public class Leitor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
