namespace ExercicioBiblioteca.Models
{
    // Classe responsável por criar o modelo da tabela 'livros'.
    public class Livro
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int ISBN { get; set; }
        public int AnoLancamento { get; set; }
        // Propriedade da classe 'autor' responsável pelo rela-
        // cionamento com a tabela 'autor'.
        public Autor Autor { get; set; }
        // FOREIGN KEY(CodigoAutor) REFERENCES autor(Codigo).
        public int CodigoAutor { get; set; }
        public string CodigoEditora { get; set; }
    }
}
