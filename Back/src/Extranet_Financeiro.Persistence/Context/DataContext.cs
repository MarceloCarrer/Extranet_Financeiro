using Extranet_Financeiro.Domain;
using Microsoft.EntityFrameworkCore;

namespace Extranet_Financeiro.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<AnoSemestre> AnoSemestres { get; set; }
        public DbSet<PoloRelatorio> PoloRelatorios { get; set; }
        public DbSet<PoloTurma> PoloTurmas { get; set; }

    }
}