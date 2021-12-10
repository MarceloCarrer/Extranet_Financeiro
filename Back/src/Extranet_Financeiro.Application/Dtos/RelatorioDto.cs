using System.Collections.Generic;

namespace Extranet_Financeiro.Application.Dtos
{
    public class RelatorioDto
    {
        public int Id { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }
        
        public decimal ValorPago { get; set; }
        
        public decimal PorcSenacrs { get; set; }
        
        public decimal PorcPolo { get; set; }
        
        public decimal Devolucao { get; set; }
        
        public decimal PorcDevSenacrs { get; set; }
        
        public decimal PorcDevPolo { get; set; }

        public string DataRegistro { get; set; }

        public string DataAtualizacao { get; set; }

        //public IEnumerable<PoloRelatorioDto> PoloRelatorio { get; set; }

    }
}