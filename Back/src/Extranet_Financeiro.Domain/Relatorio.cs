using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extranet_Financeiro.Domain
{
    public class Relatorio
    {
        public int Id { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

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

        public DateTime DataRegistro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public IEnumerable<PoloRelatorio> PoloRelatorio { get; set; }
    }
}