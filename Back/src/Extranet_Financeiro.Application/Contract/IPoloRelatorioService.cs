using System.Threading.Tasks;
using Extranet_Financeiro.Application.Dtos;

namespace Extranet_Financeiro.Application.Contract
{
    public interface IPoloRelatorioService
    {
        Task<PoloRelatorioDto[]> GetAllPolosPorRelatorioAsync(int relatorioId);
        Task<PoloRelatorioDto> GetPolosByIdAsync(int poloRelatorioId);
        Task<PoloRelatorioDto[]> GetAllPolosByNomeAsync(string nome);
    }
}