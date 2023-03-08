using Microsoft.EntityFrameworkCore;
using ProjectTime.Data.Models;

namespace ProjectTime.Data.Context
{
    public class DataContext : DbContext
    {
        private readonly DataContext _context;
        public DataContext() {}

         public DataContext(DataContext context)
        {
            _context = context;
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
    }
}