using System.Threading.Tasks;
using Extranet_Financeiro.Domain;

namespace Extranet_Financeiro.Persistence.Contract
{
    public interface IRelatorioPersistence
    {
        Task<Relatorio[]> GetAllRelatoriosAsync();
        Task<Relatorio> GetRelatorioByIdAsync(int relatorioId);
    }
}