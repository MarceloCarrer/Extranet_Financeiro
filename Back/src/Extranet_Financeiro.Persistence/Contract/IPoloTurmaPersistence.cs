using System.Threading.Tasks;
using Extranet_Financeiro.Domain;

namespace Extranet_Financeiro.Persistence.Contract
{
    public interface IPoloTurmaPersistence
    {
        Task<PoloTurma[]> GetAllTurmasPorPoloAsync(int poloRelatorioId);
        Task<PoloTurma> GetTurmasByIdAsync(int turmaId);
        Task<PoloTurma[]> GetAllTurmasByDescricaoAsync(string descricao);
    }
}