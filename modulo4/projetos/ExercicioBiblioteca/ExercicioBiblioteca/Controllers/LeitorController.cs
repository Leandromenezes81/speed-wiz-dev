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
    public class LeitorController : ControllerBase
    {
        private readonly BibliotecaDbContext _bibliotecaDbContext;

        public LeitorController(BibliotecaDbContext bibliotecaDbContext)
        {
            _bibliotecaDbContext = bibliotecaDbContext;
        }

        [HttpGet("listar-leitor")]
        public async Task<IActionResult> Listar()
        {
            return Ok(await _bibliotecaDbContext.Leitores.ToListAsync());
        }

        // Atualizar leitor.

        [HttpPut("atualizar-leitor")]

        public async Task<IActionResult> Atualizar(AtualizarLeitorInput dadosEntrada)
        {
            var leitor = await _bibliotecaDbContext.Leitores.Where(x => x.Codigo == dadosEntrada.Codigo).FirstOrDefaultAsync();
            if (leitor == null)
                return NotFound("Leitor não encontrado.");

            leitor.Nome = dadosEntrada.Nome;
            leitor.CPF = dadosEntrada.CPF;
            leitor.Email = dadosEntrada.Email;
            leitor.Telefone = dadosEntrada.Telefone;

            _bibliotecaDbContext.Leitores.Update(leitor);
            await _bibliotecaDbContext.SaveChangesAsync();

            return Ok(leitor);
        }

        // Cadastrar leitores.

        [HttpPost("cadastrar-leitor")]
        public async Task<IActionResult> CadastrarLeitor(LeitorInput dadosEntrada)
        {
            var leitor = new Leitor()
            {
                Nome = dadosEntrada.Nome,
                CPF = dadosEntrada.CPF,
                Email = dadosEntrada.Email,
                Telefone = dadosEntrada.Telefone
            };

            await _bibliotecaDbContext.Leitores.AddAsync(leitor);
            await _bibliotecaDbContext.SaveChangesAsync();

            return Ok(
                        new
                        {
                            success = true,

                            data = new
                            {
                                codigoLeitor = leitor.Codigo,
                                email = leitor.Email
                            }

                        }
                     );
        }

        // Apagando leitores do registro

        [HttpDelete("apagar-leitor")]
        public async Task<IActionResult> Deletar(int codigo)
        {
            var leitor = await _bibliotecaDbContext.Leitores.Where(x => x.Codigo == codigo).FirstOrDefaultAsync();
            if (leitor == null)
                return NotFound("Leitor não encontrado.");
            
            _bibliotecaDbContext.Leitores.Remove(leitor);
            await _bibliotecaDbContext.SaveChangesAsync();

            return Ok("Registro deletado com sucesso.");
        }
    }
}
