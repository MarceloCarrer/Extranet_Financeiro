using System;

namespace Extranet_Financeiro.API.Models
{
    public class Relatorio
    {
        public int RelatorioId { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public decimal ValorPago { get; set; }

        public decimal PorcSenacrs { get; set; }

        public decimal PorcPolo { get; set; }

        public decimal Devolucao { get; set; }

        public decimal PorcDevSenacrs { get; set; }

        public decimal PorcDevPolo { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}