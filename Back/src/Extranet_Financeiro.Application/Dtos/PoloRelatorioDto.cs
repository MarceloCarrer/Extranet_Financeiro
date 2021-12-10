using System.Collections.Generic;

namespace Extranet_Financeiro.Application.Dtos
{
    public class PoloRelatorioDto
    {
        public int Id { get; set; }

        public int PoloId { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public string DR { get; set; }

        public string Nome { get; set; }
        
        public string CNPJ { get; set; }
           
        public decimal ValorPago { get; set; }
        
        public decimal PorcSenacrs { get; set; }
        
        public decimal PorcPolo { get; set; }
        
        public decimal Devolucao { get; set; }
        
        public decimal PorcDevSenacrs { get; set; }
        
        public decimal PorcDevPolo { get; set; }

        public int RelatorioId { get; set; }

        //public RelatorioDto Relatorio { get; set; }

        //public IEnumerable<PoloTurmaDto> PoloTurma { get; set; }

    }
}