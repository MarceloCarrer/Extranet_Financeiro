using AutoMapper;
using Extranet_Financeiro.Application.Dtos;
using Extranet_Financeiro.Domain;

namespace Extranet_Financeiro.Application.Helpers
{
    public class ExtranetFinanceiroProfile : Profile
    {
        public ExtranetFinanceiroProfile()
        {
            CreateMap<Relatorio, RelatorioDto>();
            CreateMap<PoloRelatorio, PoloRelatorioDto>();
            CreateMap<PoloTurma, PoloTurmaDto>();
        }
    }
}