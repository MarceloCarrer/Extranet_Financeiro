using System.ComponentModel.DataAnnotations.Schema;

namespace Extranet_Financeiro.Domain
{
    public class PoloTurma
    {
        public int Id { get; set; }

        public int TurmaId { get; set; }

        public string Turma { get; set; }

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

        public double PercenSenacrs { get; set; }

        public double PercenPolo { get; set; }

        public int PoloRelatorioId { get; set; }

        public PoloRelatorio PoloRelatorio { get; set; }
    }
}