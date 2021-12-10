using AgendaComDapper.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaComDapper.Repositorio
{
    // Classe reponsável por manipular os dados e conexão ao Banco de Dados
    public class ContatoRepositorio
    {
        private readonly IDbConnection _dbConnection;

        public ContatoRepositorio(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Listar contatos por telefone.
        public async Task<Contato> ObterContatoPeloNumeroTelefone(string telefone)
        {
            var comandoSql = "SELECT * FROM contatos WHERE telefone = @telefone";
            var contato = await _dbConnection.QueryFirstOrDefaultAsync<Contato>(comandoSql,
                                                          new
                                                          {
                                                              telefone
                                                          });
            return contato;
        }

        // Listar todos os contatos.
        public async Task<IList<Contato>> ListarContatos() 
        {
            var comandoSql = "SELECT * FROM contatos";
            var contatos = await _dbConnection.QueryAsync<Contato>(comandoSql);
            return contatos.ToList();
        }

        // Adicionar contatos.
        public async Task<bool> AdicionarContatos(Contato contato)
        {
            var comandoSql = "INSERT INTO contatos (Nome,Apelido,Telefone,Email) VALUES (@nome,@apelido,@telefone,@email)";
            var result = await _dbConnection.ExecuteAsync(comandoSql,
                                                          new 
                                                          {
                                                               nome = contato.Nome,
                                                               apelido = contato.Apelido,
                                                               telefone = contato.Telefone,
                                                               email = contato.Email
                                                          });
            return result > 0;
        }

        // Atualizar contatos.
        public async Task<bool> AtualizarContatos(Contato contato) 
        {
            var comandoSql = "UPDATE TO contatos SET Nome = @nome, Telefone = @telefone, Email = @email WHERE Id = @id)";
            var result = await _dbConnection.ExecuteAsync(comandoSql,
                                                          new
                                                          {
                                                              nome = contato.Nome,
                                                              telefone = contato.Telefone,
                                                              email = contato.Email,
                                                              id = contato.Id
                                                          });
            return result > 0;
        }

        // Remover contatos.
        public async Task<bool> RemoverContatos(int Idcontato)
        {
            var comandoSql = "DELETE FROM contatos WHERE Id = @id)";
            var result = await _dbConnection.ExecuteAsync(comandoSql,
                                                          new
                                                          {                                                              
                                                              id = Idcontato
                                                          });
            return result > 0;
        }
    }
}
