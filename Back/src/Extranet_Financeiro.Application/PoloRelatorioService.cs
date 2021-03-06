using System;
using System.Threading.Tasks;
using AutoMapper;
using Extranet_Financeiro.Application.Contract;
using Extranet_Financeiro.Application.Dtos;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Contract;

namespace Extranet_Financeiro.Application
{
    public class PoloRelatorioService : IPoloRelatorioService
    {
        private readonly IPoloRelatorioPersistence _poloRelatorioPersistence;
        private readonly IMapper _mapper;
        
        public PoloRelatorioService(IPoloRelatorioPersistence poloRelatorioPersistence, IMapper mapper)
        {
            _poloRelatorioPersistence = poloRelatorioPersistence;
            _mapper = mapper;
        }

        public async Task<PoloRelatorioDto[]> GetAllPolosPorRelatorioAsync(int relatorioId)
        {
            try
            {
                var poloRelatorios = await _poloRelatorioPersistence.GetAllPolosPorRelatorioAsync(relatorioId);
                if (poloRelatorios == null)
                {
                    return null;
                }

                var result = _mapper.Map<PoloRelatorioDto[]>(poloRelatorios);

                return result;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public async Task<PoloRelatorioDto[]> GetAllPolosByNomeAsync(string nome)
        {
            try
            {
                var poloRelatorio = await _poloRelatorioPersistence.GetAllPolosByNomeAsync(nome);
                if (poloRelatorio == null)
                {
                    return null;
                }

                var result = _mapper.Map<PoloRelatorioDto[]>(poloRelatorio);

                return result;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public async Task<PoloRelatorioDto> GetPolosByIdAsync(int poloRelatorioId)
        {
            try
            {
                var poloRelatorio = await _poloRelatorioPersistence.GetPolosByIdAsync(poloRelatorioId);
                if (poloRelatorio == null)
                {
                    return null;
                }

                var result = _mapper.Map<PoloRelatorioDto>(poloRelatorio);

                return result;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }
    }
}