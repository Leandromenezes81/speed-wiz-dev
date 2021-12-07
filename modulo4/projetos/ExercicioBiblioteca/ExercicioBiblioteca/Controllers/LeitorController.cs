using ExercicioBiblioteca.Context;
using ExercicioBiblioteca.InputModel;
using ExercicioBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> bbd172297ae0b9a6e6094e764794cbc971f8036b
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca.Controllers
{
    [ApiController]
<<<<<<< HEAD
    [Route ("api/[controller]")]
=======
    [Route("api/[controller]")]
>>>>>>> bbd172297ae0b9a6e6094e764794cbc971f8036b
    public class LeitorController : ControllerBase
    {
        private readonly BibliotecaDbContext _bibliotecaDbContext;

        public LeitorController(BibliotecaDbContext bibliotecaDbContext)
        {
            _bibliotecaDbContext = bibliotecaDbContext;
        }
<<<<<<< HEAD
        // Listar leitores.

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

        // Cadastrar leitores
        [HttpPost("atualizar-leitor")]
        public async Task<IActionResult> CadastrarLeitor (LeitorInput dadosEntrada)
=======

        [HttpPost]
        public async Task<IActionResult> CadastrarLeitor(LeitorInput dadosEntrada) 
>>>>>>> bbd172297ae0b9a6e6094e764794cbc971f8036b
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
<<<<<<< HEAD
                            data = new 
=======
                            data = new
>>>>>>> bbd172297ae0b9a6e6094e764794cbc971f8036b
                            {
                                codigoLeitor = leitor.Codigo,
                                email = leitor.Email
                            }
<<<<<<< HEAD
                        }   
                     );
        }
=======

                        }
                     );
        }

>>>>>>> bbd172297ae0b9a6e6094e764794cbc971f8036b
    }
}
