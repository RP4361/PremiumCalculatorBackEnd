using Microsoft.EntityFrameworkCore;
using Domain;


namespace DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Occupation>? Occupations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Occupation>()
                .HasData(
                    new Occupation
                    {
                        Id = 1,
                        OccupationName = "Cleaner",
                        Rating = "Light Manual",
                        Factor = 1.5
                    },

                    new Occupation
                    {
                        Id = 2,
                        OccupationName = "Doctor",
                        Rating = "Professional",
                        Factor = 1.0
                    },
                    new Occupation
                    {
                        Id = 3,
                        OccupationName = "Author",
                        Rating = "White Collar",
                        Factor = 1.25
                    },
                    new Occupation
                    {
                        Id = 4,
                        OccupationName = "Farmer",
                        Rating = "Heavy Manual",
                        Factor = 1.75
                    },
                    new Occupation
                    {
                        Id = 5,
                        OccupationName = "Mechanic",
                        Rating = "Heavy Manual",
                        Factor = 1.75
                    },
                    new Occupation
                    {
                        Id = 6,
                        OccupationName = "Florist",
                        Rating = "Light Manual",
                        Factor = 1.5
                    }

                );
        }
    }
}