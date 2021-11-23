using System.Linq;
using System.Threading.Tasks;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Context;
using Extranet_Financeiro.Persistence.Contract;
using Microsoft.EntityFrameworkCore;

namespace Extranet_Financeiro.Persistence
{
    public class RelatorioPersistence : IRelatorioPersistence
    {
        private readonly DataContext _context;
        public RelatorioPersistence(DataContext context)
        {
            _context = context;
        }

        public async Task<Relatorio[]> GetAllRelatoriosAsync()
        {
            IQueryable<Relatorio> query = _context.Relatorios
                .Include(r => r.PoloRelatorio);

            query = query.AsNoTracking().OrderByDescending(r => r.Ano)
                         .ThenByDescending(r => r.Mes);

            return await query.ToArrayAsync();
        }

        public async Task<Relatorio> GetRelatorioByIdAsync(int relatorioId)
        {
            IQueryable<Relatorio> query = _context.Relatorios
                .Include(r => r.PoloRelatorio);

            query = query.AsNoTracking()
                         .OrderByDescending(r => r.Ano)
                         .ThenByDescending(r => r.Mes)
                         .Where(r => r.Id == relatorioId);

            return await query.FirstOrDefaultAsync();
        }
    }
}