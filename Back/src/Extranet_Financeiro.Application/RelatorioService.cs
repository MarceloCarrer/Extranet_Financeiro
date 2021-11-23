using System;
using System.Threading.Tasks;
using Extranet_Financeiro.Application.Contract;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Contract;

namespace Extranet_Financeiro.Application
{
    public class RelatorioService : IRelatorioService
    {
        private readonly IRelatorioPersistence _relatorioPersistence;
        public RelatorioService(IRelatorioPersistence relatorioPersistence)
        {
            _relatorioPersistence = relatorioPersistence;
        }

        public async Task<Relatorio[]> GetAllRelatoriosAsync()
        {
            try
            {
                 var relatorios = await _relatorioPersistence.GetAllRelatoriosAsync();
                 if (relatorios == null)
                 {
                     return null;
                 }

                 return relatorios;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Relatorio> GetRelatorioByIdAsync(int relatorioId)
        {
            try
            {
                 var relatorios = await _relatorioPersistence.GetRelatorioByIdAsync(relatorioId);
                 if (relatorios == null)
                 {
                     return null;
                 }

                 return relatorios;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }
    }
}