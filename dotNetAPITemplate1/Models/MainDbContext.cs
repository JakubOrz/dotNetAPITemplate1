using dotNetAPITemplate1.EFConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dotNetAPITemplate1.Models
{
    public class MainDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MainDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MainDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        
        public DbSet<SampleOne> MoreModels { get; set;  }
        public DbSet<SampleMore> SampleModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SampleEfConfiguration());
            modelBuilder.ApplyConfiguration(new MoreModelEfConfiguriation());

            modelBuilder.Entity<SampleOne>(sampleModel =>
            {
                sampleModel.HasData(
                    new SampleOne {Pole = "pierwsze", IdSample = 1}
                );
            });

            modelBuilder.Entity<SampleMore>(moremodel =>
            {
                moremodel.HasData(
                    new SampleMore {MoreModelId = 1, NazwaModelu = "Fajna nazwa", IdOne = 1},
                    new SampleMore {MoreModelId = 2, NazwaModelu = "Drugi model", IdOne = 1}
                );
            });
        }
        
        
    }
}