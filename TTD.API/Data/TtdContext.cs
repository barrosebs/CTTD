using Microsoft.EntityFrameworkCore;
using TTD.API.Model;

namespace TTD.API.Data
{
    public class TtdContext : DbContext
    {
        public TtdContext(DbContextOptions<TtdContext> options) : base(options) { }
        public DbSet<Macroprocesso> Macroprocessos { get; set; }
    }
} 