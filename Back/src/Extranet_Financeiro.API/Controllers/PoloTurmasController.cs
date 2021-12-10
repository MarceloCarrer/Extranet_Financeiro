using System;
using System.Threading.Tasks;
using Extranet_Financeiro.Application.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Extranet_Financeiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoloTurmasController : ControllerBase
    {
        private readonly IPoloTurmaService _poloTurmaService;

        public PoloTurmasController(IPoloTurmaService poloTurmaService)
        {
            _poloTurmaService = poloTurmaService;
        }

        [HttpGet("poloRelatorioId/{poloRelatorioId}")]
        public async Task<IActionResult> GetAllTurmasPorPolo(int poloRelatorioId)
        {
            try
            {
                var poloTurmas = await _poloTurmaService.GetAllTurmasPorPoloAsync(poloRelatorioId);
                if (poloTurmas == null)
                {
                    return NoContent();
                }

                return Ok(poloTurmas);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar turmas. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTurmasById(int id)
        {
            try
            {
                var poloTurma = await _poloTurmaService.GetTurmasByIdAsync(id);
                if (poloTurma == null)
                {
                    return NoContent();
                }

                return Ok(poloTurma);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar turmas. Erro: {ex.Message}");
            }
        }

        [HttpGet("descricao/{descricao}")]
        public async Task<IActionResult> GetAllTurmasByDescricao(string descricao)
        {
            try
            {
                var poloTurma = await _poloTurmaService.GetAllTurmasByDescricaoAsync(descricao);
                if (poloTurma == null)
                {
                    return NoContent();
                }

                return Ok(poloTurma);
            }
            catch (Exception ex)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar polos. turmas: {ex.Message}");
            }
        }
    }
}
