using System.Linq;
using System.Threading.Tasks;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Context;
using Extranet_Financeiro.Persistence.Contract;
using Microsoft.EntityFrameworkCore;

namespace Extranet_Financeiro.Persistence
{
    public class PoloTurmaPersistence : IPoloTurmaPersistence
    {
        private readonly DataContext _context;
        public PoloTurmaPersistence(DataContext context)
        {
            _context = context;
        }

        public async Task<PoloTurma[]> GetAllTurmasPorPoloAsync(int poloRelatorioId)
        {
            IQueryable<PoloTurma> query = _context.PoloTurmas
                .Include(t => t.PoloRelatorio);

            query = query.AsNoTracking()
                         .OrderBy(t => t.Turma)
                         .Where(t => t.PoloRelatorioId == poloRelatorioId);
            
            return await query.ToArrayAsync();
        }

        public async Task<PoloTurma> GetTurmasByIdAsync(int turmaId)
        {
            IQueryable<PoloTurma> query = _context.PoloTurmas
                .Include(t => t.PoloRelatorio);

            query = query.AsNoTracking()
                         .OrderBy(t => t.Turma)
                         .Where(t => t.Id == turmaId);
            
            return await query.FirstOrDefaultAsync();
        }
        
        public async Task<PoloTurma[]> GetAllTurmasByDescricaoAsync(string descricao)
        {
            IQueryable<PoloTurma> query = _context.PoloTurmas
                .Include(t => t.PoloRelatorio);

            query = query.AsNoTracking()
                         .OrderBy(t => t.Turma)
                         .Where(p => p.Turma.ToLower().Contains(descricao.ToLower()));
            
            return await query.ToArrayAsync();
        }
    }
}