using System.Threading.Tasks;
using Extranet_Financeiro.Application.Dtos;

namespace Extranet_Financeiro.Application.Contract
{
    public interface IPoloTurmaService
    {
        Task<PoloTurmaDto[]> GetAllTurmasPorPoloAsync(int poloRelatorioId);
        Task<PoloTurmaDto> GetTurmasByIdAsync(int turmaId);
        Task<PoloTurmaDto[]> GetAllTurmasByDescricaoAsync(string descricao);
    }
}