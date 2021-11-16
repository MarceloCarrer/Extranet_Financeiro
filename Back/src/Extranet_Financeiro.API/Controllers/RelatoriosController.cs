using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extranet_Financeiro.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Extranet_Financeiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {     

        public IEnumerable<Relatorio> _relatorio = new Relatorio[] {
            new Relatorio() {
                RelatorioId = 1,
                Mes = 10,
                Ano = 2021,
                ValorPago = 3890577.79M,
                PorcSenacrs = 23032216.71M,
                PorcPolo = 1587356.119M,
                Devolucao = 92041.90M,
                PorcDevSenacrs = 51056.04M,
                PorcDevPolo = 40985.86M,
                DataRegistro = DateTime.Now.AddDays(0)
            }
        };

        public RelatoriosController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Relatorio> Get()
        {
            return _relatorio;
        }

        
        [HttpGet("{id}")]
        public IEnumerable<Relatorio> GetById(int id)
        {
            return _relatorio.Where(r => r.RelatorioId == id);
        }
    }
}
