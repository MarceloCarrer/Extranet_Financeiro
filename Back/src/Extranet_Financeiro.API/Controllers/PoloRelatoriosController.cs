using System;
using System.Threading.Tasks;
using Extranet_Financeiro.Application.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Extranet_Financeiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoloRelatoriosController : ControllerBase
    {
        private readonly IPoloRelatorioService _poloRelatorioService;

        public PoloRelatoriosController(IPoloRelatorioService poloRelatorioService)
        {
            _poloRelatorioService = poloRelatorioService;
        }

        [HttpGet("relatorioId/{relatorioId}")]
        public async Task<IActionResult> GetAllPolosPorRelatorioAsync(int relatorioId)
        {
            try
            {
                var poloRelatorios = await _poloRelatorioService.GetAllPolosPorRelatorioAsync(relatorioId);
                if (poloRelatorios == null)
                {
                    return NoContent();
                }

                return Ok(poloRelatorios);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar polos. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var poloRelatorio = await _poloRelatorioService.GetPolosByIdAsync(id);
                if (poloRelatorio == null)
                {
                    return NoContent();
                }

                return Ok(poloRelatorio);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar polos. Erro: {ex.Message}");
            }
        }

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetByNome(string nome)
        {
            try
            {
                var poloRelatorio = await _poloRelatorioService.GetAllPolosByNomeAsync(nome);
                if (poloRelatorio == null)
                {
                    return NoContent();
                }

                return Ok(poloRelatorio);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar polos. Erro: {ex.Message}");
            }
        }
    }
}
