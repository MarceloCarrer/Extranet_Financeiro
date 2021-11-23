using System;
using System.Threading.Tasks;
using Extranet_Financeiro.Application.Contract;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Contract;

namespace Extranet_Financeiro.Application
{
    public class PoloRelatorioService : IPoloRelatorioService
    {
        private readonly IPoloRelatorioPersistence _poloRelatorioPersistence;
        public PoloRelatorioService(IPoloRelatorioPersistence poloRelatorioPersistence)
        {
            _poloRelatorioPersistence = poloRelatorioPersistence;
        }
//GetPolosPorRelatorioAsync(int relatorioId)
        public async Task<PoloRelatorio[]> GetAllPolosPorRelatorioAsync(int relatorioId)
        {
            try
            {
                 var poloRelatorios = await _poloRelatorioPersistence.GetAllPolosPorRelatorioAsync(relatorioId);
                 if (poloRelatorios == null)
                 {
                     return null;
                 }

                 return poloRelatorios;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public async Task<PoloRelatorio[]> GetAllPolosByNomeAsync(string nome)
        {
            try
            {
                 var poloRelatorio = await _poloRelatorioPersistence.GetAllPolosByNomeAsync(nome);
                 if (poloRelatorio == null)
                 {
                     return null;
                 }

                 return poloRelatorio;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public async Task<PoloRelatorio> GetPolosByIdAsync(int poloRelatorioId)
        {
            try
            {
                 var poloRelatorio = await _poloRelatorioPersistence.GetPolosByIdAsync(poloRelatorioId);
                 if (poloRelatorio == null)
                 {
                     return null;
                 }

                 return poloRelatorio;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }
    }
}