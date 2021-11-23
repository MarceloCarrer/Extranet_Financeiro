using System.Threading.Tasks;
using Extranet_Financeiro.Domain;

namespace Extranet_Financeiro.Application.Contract
{
    public interface IPoloRelatorioService
    {
        Task<PoloRelatorio[]> GetAllPolosPorRelatorioAsync(int relatorioId);
        Task<PoloRelatorio> GetPolosByIdAsync(int poloRelatorioId);
        Task<PoloRelatorio[]> GetAllPolosByNomeAsync(string nome);
    }
}