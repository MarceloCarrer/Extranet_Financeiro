using Extranet_Financeiro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Extranet_Financeiro.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<AnoSemestre> AnoSemestres { get; set; }
    }
}