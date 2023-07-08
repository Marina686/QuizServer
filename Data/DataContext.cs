using Microsoft.EntityFrameworkCore;
using QuizServer.Models;

namespace QuizServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<DbModel> DbModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbModel>()
                .Property(c => c.ExtraNote)
                .HasColumnName("extra_note");
        }
    }
}