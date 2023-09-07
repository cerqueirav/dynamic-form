using dynamic_form.Models;
using Microsoft.EntityFrameworkCore;

namespace dynamic_form.Data.Context
{
    public class DynamicContext : DbContext
    {
        public DynamicContext(DbContextOptions<DynamicContext> options, ILoggerFactory loggerFactory) : base(options) { _loggerFactory = loggerFactory; }

        public DbSet<Field> Fields { get; set; }
        public DbSet<TypeField> Types { get; set; }

        private readonly ILoggerFactory _loggerFactory;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }
    }
}
