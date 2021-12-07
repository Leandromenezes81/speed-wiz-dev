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
    public class AutoresController : ControllerBase
    {
        private readonly BibliotecaDbContext _bibliotecaDbContext;

        public AutoresController(BibliotecaDbContext bibliotecaDbContext)
        {
            _bibliotecaDbContext = bibliotecaDbContext;
        }

        // Listar autores (filtrar por nome).

        [HttpGet("filtrar-por-nome")]
        public async Task<IActionResult> FiltrarPorNome(string nome)
        {
            var autores = await _bibliotecaDbContext.Autores.Where(x => x.Nome.Contains(nome)).ToListAsync();
            if (autores.Any())
                return Ok(autores);

            return NotFound("Nenhum autor encontrado.");
        }

        // Listar autores.

        [HttpGet("listar-todos")]
        public async Task<IActionResult> Listar()
        {
            return Ok(await _bibliotecaDbContext.Autores.ToListAsync());
        }

        // Atualizar autores.
        [HttpPut("atualizar-autor")]
        public async Task<IActionResult> Atualizar(AtualizarAutorInput dadosEntrada)
        {
            var autor = await _bibliotecaDbContext.Autores.Where(x => x.Codigo == dadosEntrada.Codigo).FirstOrDefaultAsync();
            if (autor == null)
                return NotFound("Autor não encontrado");
            autor.Nome = dadosEntrada.Nome;
            _bibliotecaDbContext.Autores.Update(autor);
            await _bibliotecaDbContext.SaveChangesAsync();

            return Ok(autor);
        }


        // Cadastrar autores.
        [HttpPost("cadastrar-autores")]
        public async Task<IActionResult> CadastrarAutor(AutorInput dadosEntrada)
        {
            var autor = new Autor()
            {
                Nome = dadosEntrada.Nome
            };

            // Propriedade DbSet
            await _bibliotecaDbContext.Autores.AddAsync(autor);
            await _bibliotecaDbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
