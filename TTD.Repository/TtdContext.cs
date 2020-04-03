using Microsoft.EntityFrameworkCore;
using TTD.Domain;

namespace TTD.Repository
{
    public class TtdContext : DbContext
    {
        public TtdContext(DbContextOptions<TtdContext> options) : base(options) { }
        public DbSet<Macroprocesso> Macroprocessos { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<SubProcesso> SubProcessos { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
    }
} 