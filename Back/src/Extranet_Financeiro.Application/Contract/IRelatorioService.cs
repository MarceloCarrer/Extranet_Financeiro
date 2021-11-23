using System.Threading.Tasks;
using Extranet_Financeiro.Domain;

namespace Extranet_Financeiro.Application.Contract
{
    public interface IRelatorioService
    {
        Task<Relatorio[]> GetAllRelatoriosAsync();
        Task<Relatorio> GetRelatorioByIdAsync(int relatorioId);
    }
}