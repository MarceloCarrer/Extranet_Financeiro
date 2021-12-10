using System.Threading.Tasks;
using Extranet_Financeiro.Application.Dtos;

namespace Extranet_Financeiro.Application.Contract
{
    public interface IRelatorioService
    {
        Task<RelatorioDto[]> GetAllRelatoriosAsync();
        Task<RelatorioDto> GetRelatorioByIdAsync(int relatorioId);
    }
}