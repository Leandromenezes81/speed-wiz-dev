using ExercicioBiblioteca.Context;
using ExercicioBiblioteca.InputModel;
using ExercicioBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly BibliotecaDbContext _bibliotecaDbContext;

        public LivroController(BibliotecaDbContext bibliotecaDbContext)
        {
            _bibliotecaDbContext = bibliotecaDbContext;
        }

        // Filtrar por ano de lançamento.

        [HttpGet("filtrar-por-ano-lancamento")]
        public async Task<IActionResult> FiltrarPorAnoLancamento(int anoLancamento)
        {
            var livros = await _bibliotecaDbContext.Livros.Where(x => x.AnoLancamento == anoLancamento).ToListAsync();
            if (livros.Any())
                return Ok(livros);

            return NotFound("Nenhum livro encontrado.");
        }

        // Filtrar por descrição.

        [HttpGet("filtrar-por-descricao")]
        public async Task<IActionResult> FiltrarPorDescricao(string descricao)
        {
            var livros = await _bibliotecaDbContext.Livros.Where(x => x.Descricao.Contains(descricao)).ToListAsync();
            if (livros.Any())
                return Ok(livros);

            return NotFound("Nenhum livro encontrado.");
        }

        // Listar novos livros por ISBN

        [HttpGet ("filtrar-por-isbn")]
        public async Task<IActionResult> FiltrarPorISBN(int isbn)
        {            
            var livro = await _bibliotecaDbContext.Livros.Where(x => x.ISBN == isbn).FirstOrDefaultAsync();
            if (livro == null)            
                return NotFound("Livro não encontrado no banco de dados.");
            
            return Ok(livro);
        }


        // Listar novos livros

        [HttpGet("listar-todos")]
        public async Task<IActionResult> ListarLivros() 
        {
            return Ok(await _bibliotecaDbContext.Livros.ToListAsync());
        }

        // Atualizar livros (editar).

        [HttpPut("atualizar-livro")]
        public async Task<IActionResult> Atualizar(AtualizarLivroInput dadosEntrada)
        {
            var livro = await _bibliotecaDbContext.Livros.Where(x => x.Codigo == dadosEntrada.Codigo).FirstOrDefaultAsync();
            if (livro == null)
                return NotFound("Livro não encontrado no banco de dados.");

            livro.Descricao = dadosEntrada.Descricao;
            livro.ISBN = dadosEntrada.ISBN;
            livro.AnoLancamento = dadosEntrada.AnoLancamento;

            _bibliotecaDbContext.Livros.Update(livro);
            await _bibliotecaDbContext.SaveChangesAsync();

            return Ok();
        }

        // Cadastrar novos livros.
        [HttpPost("cadastrar-livros")]
        public async Task<IActionResult> CadastrarLivro(LivroInput dadosEntrada)
        {
            var livro = new Livro()
            {
                Descricao = dadosEntrada.Descricao,
                ISBN = dadosEntrada.ISBN,
                AnoLancamento = dadosEntrada.AnoLancamento,
                CodigoEditora = dadosEntrada.CodigoEditora,
                CodigoAutor = dadosEntrada.CodigoAutor
            };

            // Propriedade DbSet
            await _bibliotecaDbContext.Livros.AddAsync(livro);
            await _bibliotecaDbContext.SaveChangesAsync();

            return Ok(
                        new 
                        {
                            sucess = true,
                            data = new
                            {
                                descricao = livro.Descricao,
                                isbn = livro.ISBN
                            }
                        }
                     );
        }
    }
}
