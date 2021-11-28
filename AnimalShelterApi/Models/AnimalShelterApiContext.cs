using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
      : base(options)
      {
      }

      public DbSet<Animal> Animals { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Species = "Dog", Name = "Spark", Gender = "Female", Age = 1, Backstory = "Born recently with many siblings"},
            new Animal { AnimalId = 2, Species = "Cat", Name = "Boots", Gender = "Male", Age = 2, Backstory = "Raised by foster family"},
            new Animal { AnimalId = 3, Species = "Dog", Name = "Charlie", Gender = "Female", Age = 7, Backstory = "Raised to believe she is a husky"},
            new Animal { AnimalId = 4, Species = "Cat", Name = "Kona", Gender = "Female", Age = 5, Backstory = "Found running the streets of Portland"},
            new Animal { AnimalId = 5, Species = "Dog", Name = "Bob", Gender = "Male", Age = 3, Backstory = "Very generic Name not so generic puppy"},
            new Animal { AnimalId = 6, Species = "Bird", Name = "Kyro", Gender = "Female", Age = 9, Backstory = "Saved from a traveling circus"}
          );
      }
  }
}