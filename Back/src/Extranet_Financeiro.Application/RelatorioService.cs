using System;
using System.Threading.Tasks;
using AutoMapper;
using Extranet_Financeiro.Application.Contract;
using Extranet_Financeiro.Application.Dtos;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Contract;

namespace Extranet_Financeiro.Application
{
    public class RelatorioService : IRelatorioService
    {
        private readonly IRelatorioPersistence _relatorioPersistence;
        private readonly IMapper _mapper;

        public RelatorioService(IRelatorioPersistence relatorioPersistence, IMapper mapper)
        {
            _relatorioPersistence = relatorioPersistence;
            _mapper = mapper;
        }

        public async Task<RelatorioDto[]> GetAllRelatoriosAsync()
        {
            try
            {
                var relatorios = await _relatorioPersistence.GetAllRelatoriosAsync();
                if (relatorios == null)
                {
                    return null;
                }

                var result = _mapper.Map<RelatorioDto[]>(relatorios);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<RelatorioDto> GetRelatorioByIdAsync(int relatorioId)
        {
            try
            {
                var relatorio = await _relatorioPersistence.GetRelatorioByIdAsync(relatorioId);
                if (relatorio == null)
                {
                    return null;
                }

                var result = _mapper.Map<RelatorioDto>(relatorio);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}