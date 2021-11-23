using System;
using System.Threading.Tasks;
using Extranet_Financeiro.Application.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Extranet_Financeiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {
        private readonly IRelatorioService _relatorioService;

        public RelatoriosController(IRelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                 var relatorios = await _relatorioService.GetAllRelatoriosAsync();
                 if (relatorios == null)
                 {
                     return NotFound("Nenhum relatório encontrado.");
                 }

                 return Ok(relatorios);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar relatórios. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                 var relatorio = await _relatorioService.GetRelatorioByIdAsync(id);
                 if (relatorio == null)
                 {
                     return NotFound("Nenhum relatório por Id encontrado.");
                 }

                 return Ok(relatorio);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar relatórios. Erro: {ex.Message}");
            }
        }
    }
}
