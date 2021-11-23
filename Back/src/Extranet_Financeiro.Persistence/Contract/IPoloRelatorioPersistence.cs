using System.Threading.Tasks;
using Extranet_Financeiro.Domain;

namespace Extranet_Financeiro.Persistence.Contract
{
    public interface IPoloRelatorioPersistence
    {
        Task<PoloRelatorio[]> GetAllPolosPorRelatorioAsync(int relatorioId);
        Task<PoloRelatorio> GetPolosByIdAsync(int poloRelatorioId);
        Task<PoloRelatorio[]> GetAllPolosByNomeAsync(string nome);
    }
}