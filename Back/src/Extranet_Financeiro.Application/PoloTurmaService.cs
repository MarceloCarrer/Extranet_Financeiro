using System;
using System.Threading.Tasks;
using AutoMapper;
using Extranet_Financeiro.Application.Contract;
using Extranet_Financeiro.Application.Dtos;
using Extranet_Financeiro.Domain;
using Extranet_Financeiro.Persistence.Contract;

namespace Extranet_Financeiro.Application
{
    public class PoloTurmaService : IPoloTurmaService
    {
        private readonly IPoloTurmaPersistence _poloTurmaPersistence;
        private readonly IMapper _mapper;

        public PoloTurmaService(IPoloTurmaPersistence poloTurmaPersistence, IMapper mapper)
        {
            _poloTurmaPersistence = poloTurmaPersistence;
            _mapper = mapper;
        }

        public async Task<PoloTurmaDto[]> GetAllTurmasPorPoloAsync(int poloRelatorioId)
        {
            try
            {
                var poloTurmas = await _poloTurmaPersistence.GetAllTurmasPorPoloAsync(poloRelatorioId);
                if (poloTurmas == null)
                {
                    return null;
                }

                var result = _mapper.Map<PoloTurmaDto[]>(poloTurmas);

                return result;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public async Task<PoloTurmaDto> GetTurmasByIdAsync(int turmaId)
        {
            try
            {
                var poloTurma = await _poloTurmaPersistence.GetTurmasByIdAsync(turmaId);
                if (poloTurma == null)
                {
                    return null;
                }

                var result = _mapper.Map<PoloTurmaDto>(poloTurma);

                return result;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

        public async Task<PoloTurmaDto[]> GetAllTurmasByDescricaoAsync(string descricao)
        {
            try
            {
                var poloTurma = await _poloTurmaPersistence.GetAllTurmasByDescricaoAsync(descricao);
                if (poloTurma == null)
                {
                    return null;
                }

                var result = _mapper.Map<PoloTurmaDto[]>(poloTurma);

                return result;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }

    }
}