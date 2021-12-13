using AgendaComDapper.InputModel;
using AgendaComDapper.Models;
using AgendaComDapper.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaComDapper.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatosController : ControllerBase
    {
        // Utilizando a classe 'ContatoRepositorio'
        private readonly ContatoRepositorio _contatoRepositorio;

        #region Construtor
        public ContatosController(IDbConnection dbConnection)
        {
            _contatoRepositorio = new ContatoRepositorio(dbConnection);
        }
        #endregion

        [HttpGet("listar-contatos")]
        public async Task<IActionResult> Listar() 
        {
            var contato = await _contatoRepositorio.ListarContatos();
            if (!contato.Any()) // Se não exite 'contato'.
                return NotFound("Contato inesistente.");

            return Ok(contato);
        }

        [HttpPost("adicionar-contato")]
        public async Task<IActionResult> Adicionar(ContatoInput dadosEntrada) 
        {
            var contato = new Contato
            {
                Nome = dadosEntrada.Nome,
                Apelido = dadosEntrada.Apelido,
                Telefone = dadosEntrada.Telefone,
                Email = dadosEntrada.Email
            };

            // Utilizando o método 'AdicionarContato' em 'ContatoRepositorio'
            var contatoAdicionado = await _contatoRepositorio.AdicionarContatos(contato);
            if (contatoAdicionado)
                return Ok(contato);

            return StatusCode(500, "Contato não pode ser adicionado");
        }

        [HttpPut("atualizar-contato-por-telefone")]
        public async Task<IActionResult> Atualizar(AtualizarContatoInput dadosEntrada) 
        {
            // Recuperando contato no banco pelo 'Telefone'.
            var contato = await _contatoRepositorio.ObterContatoPeloNumeroTelefone(dadosEntrada.Telefone);
            if (contato == null)
                return NotFound("Contato não encontrado.");

            contato.Nome = dadosEntrada.Nome;
            contato.Apelido = dadosEntrada.Apelido;
            contato.Telefone = dadosEntrada.Telefone;
            contato.Email = dadosEntrada.Email;

            // Testando a atualização do contato.
            var contatoAtualizado = await _contatoRepositorio.AtualizarContatos(contato);
            if (contatoAtualizado)
                return Ok(contato);
            return StatusCode(500, "Contato não atualizado.");

        }

        [HttpPut("atualizar-contato-por-id")]
        public async Task<IActionResult> AtualizarPorId(AtualizarContatoInput dadosEntrada)
        {
            // Recuperando contato no banco pelo 'Id'.
            var contato = await _contatoRepositorio.ObterContatoPeloNumeroId(dadosEntrada.Id);
            if (contato == null)
                return NotFound("Contato não encontrado.");

            contato.Nome = dadosEntrada.Nome;
            contato.Apelido = dadosEntrada.Apelido;
            contato.Telefone = dadosEntrada.Telefone;
            contato.Email = dadosEntrada.Email;

            // Testando a atualização do contato.
            var contatoAtualizado = await _contatoRepositorio.AtualizarContatos(contato);
            if (contatoAtualizado)
                return Ok(contato);
            return StatusCode(500, "Contato não atualizado.");

        }

        [HttpDelete("deletar-contato")]
        public async Task<IActionResult> Deletar(int id) 
        {
            // Recuperando contato no banco pelo 'Id'.
            var contato = await _contatoRepositorio.ObterContatoPeloNumeroId(id);
            if (contato == null)
                return NotFound("Contato não encontrado.");

            var contatoRemovido = await _contatoRepositorio.RemoverContatos(id);
            if (contatoRemovido)
                return Ok("Contato removido com sucesso!");
            return StatusCode(500, "Contato não pode ser removido.");
        }

    }
}
