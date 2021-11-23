using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extranet_Financeiro.Domain
{
    public class PoloRelatorio
    {
        public int Id { get; set; }

        public int PoloId { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public string DR { get; set; }

        public string Nome { get; set; }

        #nullable enable
        public string? CNPJ { get; set; }

        #nullable disable

        [Column(TypeName = "decimal(18,4)")]
        public decimal ValorPago { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal PorcSenacrs { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal PorcPolo { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Devolucao { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal PorcDevSenacrs { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal PorcDevPolo { get; set; }

        public int RelatorioId { get; set; }

        public Relatorio Relatorio { get; set; }

        public IEnumerable<PoloTurma> PoloTurma { get; set; }
        
    }
}