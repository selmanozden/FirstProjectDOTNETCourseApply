using Microsoft.EntityFrameworkCore;

namespace courseapply.Models
{
    public class ContextModel : DbContext
    {
        public ContextModel(DbContextOptions<ContextModel> options) : base(options) { }
        public DbSet<VariableModel> Kurs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
