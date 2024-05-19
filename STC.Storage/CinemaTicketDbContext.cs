using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using STC.Storage.Entities;

namespace STC.Storage
{
    public class CinemaTicketDbContext : DbContext
    {
        private IConfiguration _configuration { get; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public CinemaTicketDbContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"server = 10.200.2.28; Database = cinema-dev-nrAlbumu; User Id = stud; Password = 123; ",x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Cinema"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}