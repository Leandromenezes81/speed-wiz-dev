using AgendaComDapper.Models;
using Dapper;
using Dapper.Contrib.Extensions;
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

        // Obter contato por 'Id'.

        public async Task<Contato> ObterContatoPeloNumeroId(int id)
        {
            /* Os comandos abaixo foram comentados para a utilização dos recursos do
            Dapper.Contrib
            */
            /*
            var comandoSql = "SELECT * FROM contatos WHERE Id = @id";
            var contato = await _dbConnection.QueryFirstOrDefaultAsync<Contato>(comandoSql,
                                                          new
                                                          {
                                                              id
                                                          });
            return contato;
            */
            // Através da Biblioteca do Dapper, o 'SELECT * FROM contatos WHERE Id = @id'
            // foi montado com o comando 'GetAsync'. Performance igual com código menor.
            var contato = await _dbConnection.GetAsync<Contato>(id);
            return contato;
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
            /* Os comandos abaixo foram comentados para a utilização dos recursos do
            Dapper.Contrib
            */
            /*
            var comandoSql = "SELECT * FROM contatos";
            var contatos = await _dbConnection.QueryAsync<Contato>(comandoSql);
            */

            var contatos = await _dbConnection.GetAllAsync<Contato>();
            return contatos.ToList();
        }

        // Adicionar contatos.
        public async Task<bool> AdicionarContatos(Contato contato)
        {
            /* Os comandos abaixo foram comentados para a utilização dos recursos do
            Dapper.Contrib
            */
            /*
            var comandoSql = "INSERT INTO contatos (Nome,Apelido,Telefone,Email) VALUES (@nome,@apelido,@telefone,@email)";
            var result = await _dbConnection.ExecuteAsync(comandoSql,
                                                          new 
                                                          {
                                                               nome = contato.Nome,
                                                               apelido = contato.Apelido,
                                                               telefone = contato.Telefone,
                                                               email = contato.Email
                                                          });
            */

            var result = await _dbConnection.InsertAsync(contato);
            return result > 0;
        }

        // Atualizar contatos.
        public async Task<bool> AtualizarContatos(Contato contato) 
        {
            /* Os comandos abaixo foram comentados para a utilização dos recursos do
            Dapper.Contrib
            */
            /*
            var comandoSql = "UPDATE contatos SET Nome = @nome, Telefone = @telefone, Email = @email WHERE Id = @id";
            var result = await _dbConnection.ExecuteAsync(comandoSql,
                                                          new
                                                          {
                                                              nome = contato.Nome,
                                                              telefone = contato.Telefone,
                                                              email = contato.Email,
                                                              id = contato.Id
                                                          });
            return result > 0;
            */
            return await _dbConnection.UpdateAsync(contato);
        }

        // Remover contatos.
        public async Task<bool> RemoverContatos(int Idcontato)
        {
            /* Os comandos abaixo foram comentados para a utilização dos recursos do
            Dapper.Contrib
            */
            /*
            var comandoSql = "DELETE FROM contatos WHERE Id = @id";
            var result = await _dbConnection.ExecuteAsync(comandoSql,
                                                          new
                                                          {                                                              
                                                              id = Idcontato
                                                          });
            return result > 0;
            */
            return await _dbConnection.DeleteAsync(new Contato() { Id = Idcontato });
        }
    }
}
