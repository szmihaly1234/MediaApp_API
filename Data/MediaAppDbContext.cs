using MediaApp_Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MediaAppDbContext : DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }

        public MediaAppDbContext()
        {
            Database.EnsureCreated();
        }
        public MediaAppDbContext(DbContextOptions<MediaAppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;
                    AttachDbFilename=|DataDirectory|\media.mdf;Integrated Security=True;MultipleActiveResultSets=true";
                optionsBuilder.UseSqlServer(conn)
                    .UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasOne(movie => movie.Studio)
                .WithMany(studio => studio.Movies)
                .HasForeignKey(movie => movie.Studio)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}