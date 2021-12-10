using AgendaComDapper.InputModel;
using AgendaComDapper.Models;
using AgendaComDapper.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

    }
}
