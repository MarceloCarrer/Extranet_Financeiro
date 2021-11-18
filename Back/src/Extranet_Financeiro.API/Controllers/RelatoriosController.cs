using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extranet_Financeiro.API.Data;
using Extranet_Financeiro.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Extranet_Financeiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {
        private readonly DataContext _context;

        public RelatoriosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Relatorio> Get()
        {
            return _context.Relatorios.OrderByDescending(r => r.Ano)
                                      .ThenByDescending(r => r.Mes);
        }

        [HttpGet("{id}")]
        public Relatorio GetById(int id)
        {
            return _context.Relatorios.FirstOrDefault(r => r.RelatorioId == id);
        }
    }
}
