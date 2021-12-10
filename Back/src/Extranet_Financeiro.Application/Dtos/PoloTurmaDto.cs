namespace Extranet_Financeiro.Application.Dtos
{
    public class PoloTurmaDto
    {
        public int Id { get; set; }

        public int TurmaId { get; set; }

        public string Turma { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }
        
        public decimal ValorPago { get; set; }
        
        public decimal PorcSenacrs { get; set; }
        
        public decimal PorcPolo { get; set; }
        
        public decimal Devolucao { get; set; }
        
        public decimal PorcDevSenacrs { get; set; }
        
        public decimal PorcDevPolo { get; set; }

        public double PercenSenacrs { get; set; }

        public double PercenPolo { get; set; }

        public int PoloRelatorioId { get; set; }

        //public PoloRelatorioDto PoloRelatorio { get; set; }
    }
}