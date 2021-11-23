using System.Linq;
using System.Threading.Tasks;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Context;
using Extranet_Financeiro.Persistence.Contract;
using Microsoft.EntityFrameworkCore;

namespace Extranet_Financeiro.Persistence
{
    public class PoloRelatorioPersistence : IPoloRelatorioPersistence
    {
        private readonly DataContext _context;
        public PoloRelatorioPersistence(DataContext context)
        {
            _context = context;
        }        

        public async Task<PoloRelatorio[]> GetAllPolosPorRelatorioAsync(int relatorioId)
        {
            IQueryable<PoloRelatorio> query = _context.PoloRelatorios
                .Include(p => p.PoloTurma);

            query = query.AsNoTracking()
                         .OrderBy(p => p.Nome)
                         .Where(p => p.RelatorioId == relatorioId);

            return await query.ToArrayAsync();
        }

        public async Task<PoloRelatorio> GetPolosByIdAsync(int poloRelatorioId)
        {
            IQueryable<PoloRelatorio> query = _context.PoloRelatorios
                .Include(p => p.PoloTurma);

            query = query.AsNoTracking()
                         .OrderBy(p => p.Nome)
                         .Where(p => p.Id == poloRelatorioId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<PoloRelatorio[]> GetAllPolosByNomeAsync(string nome)
        {
            IQueryable<PoloRelatorio> query = _context.PoloRelatorios
                .Include(p => p.PoloTurma);

            query = query.AsNoTracking()
                         .OrderBy(p => p.Nome)
                         .Where(p => p.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }
    }
}